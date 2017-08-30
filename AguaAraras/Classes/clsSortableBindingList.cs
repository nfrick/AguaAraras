using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AguaAraras {

    public class SortableBindingList<T> : BindingList<T>, IBindingListView {
        private ArrayList sortedList;
        private bool isSortedValue;

        public SortableBindingList() {
        }

        public SortableBindingList(IList<T> list) {
            foreach (object o in list) {
                this.Add((T)o);
            }
        }

        protected override bool SupportsSortingCore => true;


        protected override bool IsSortedCore => isSortedValue;

        ListSortDirection sortDirectionValue;
        PropertyDescriptor sortPropertyValue;

        protected override void ApplySortCore(PropertyDescriptor prop,
            ListSortDirection direction) {
            sortedList = new ArrayList();

            Type interfaceType = prop.PropertyType.GetInterface("IComparable");

            if (interfaceType == null && prop.PropertyType.IsValueType) {
                Type underlyingType = Nullable.GetUnderlyingType(prop.PropertyType);

                if (underlyingType != null) {
                    interfaceType = underlyingType.GetInterface("IComparable");
                }
            }

            if (interfaceType != null) {
                sortPropertyValue = prop;
                sortDirectionValue = direction;

                IEnumerable<T> query = base.Items;
                if (direction == ListSortDirection.Ascending) {
                    query = query.OrderBy(i => prop.GetValue(i));
                }
                else {
                    query = query.OrderByDescending(i => prop.GetValue(i));
                }
                int newIndex = 0;
                foreach (object item in query) {
                    this.Items[newIndex] = (T)item;
                    newIndex++;
                }
                isSortedValue = true;
                this.OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));

            }
            else {
                throw new NotSupportedException("Cannot sort by " + prop.Name +
                    ". This" + prop.PropertyType.ToString() +
                    " does not implement IComparable");
            }
        }

        protected override PropertyDescriptor SortPropertyCore => sortPropertyValue;

        protected override ListSortDirection SortDirectionCore => sortDirectionValue;

        #region IBindingListView

        #region AdvancedSorting
        public bool SupportsAdvancedSorting {
            get { return false; }
        }
        public ListSortDescriptionCollection SortDescriptions {
            get { return null; }
        }

        public void ApplySort(ListSortDescriptionCollection sorts) {
            throw new NotSupportedException();
        }

        #endregion AdvancedSorting

        public bool SupportsFiltering => true;

        private string _filterValue;

        public string Filter {
            set {
                if (_filterValue == value) return;

                // If the value is not null or empty, but doesn't
                // match expected format, throw an exception.
                if (!string.IsNullOrEmpty(value) &&
                    !Regex.IsMatch(value,
                    BuildRegExForFilterFormat(), RegexOptions.Singleline))
                    throw new ArgumentException("Filter is not in the format: propName[<>=]'value'.");

                //Turn off list-changed events.
                RaiseListChangedEvents = false;

                // If the value is null or empty, reset list.
                if (string.IsNullOrEmpty(value))
                    ResetList();
                else {
                    var count = 0;
                    var matches = value.Split(new string[] { " AND " },
                        StringSplitOptions.RemoveEmptyEntries);

                    while (count < matches.Length) {
                        var filterPart = matches[count];

                        // Check to see if the filter was set previously.
                        // Also, check if current filter is a subset of
                        // the previous filter.
                        if (!string.IsNullOrEmpty(_filterValue)
                                && !value.Contains(_filterValue))
                            ResetList();

                        // Parse and apply the filter.
                        var filterInfo = ParseFilter(filterPart);
                        ApplyFilter(filterInfo);
                        count++;
                    }
                }
                // Set the filter value and turn on list changed events.
                _filterValue = value;
                RaiseListChangedEvents = true;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));

            }
            get => _filterValue;
        }

        private List<T> originalListValue = new List<T>();
        public List<T> OriginalList => originalListValue;

        protected override void OnListChanged(ListChangedEventArgs e) {
            // If the list is reset, check for a filter. If a filter
            // is applied, don't allow items to be added to the list.
            if (e.ListChangedType == ListChangedType.Reset) {
                AllowNew = string.IsNullOrEmpty(Filter);
            }
            // Add the new item to the original list.
            if (e.ListChangedType == ListChangedType.ItemAdded) {
                OriginalList.Add(this[e.NewIndex]);
                if (!string.IsNullOrEmpty(Filter)) {
                    var cachedFilter = Filter;
                    Filter = "";
                    Filter = cachedFilter;
                }
            }
            // Remove the new item from the original list.
            if (e.ListChangedType == ListChangedType.ItemDeleted)
                OriginalList.RemoveAt(e.NewIndex);

            base.OnListChanged(e);
        }
        // Build a regular expression to determine if
        // filter is in correct format.
        public static string BuildRegExForFilterFormat() {
            var regex = new StringBuilder();

            // Look for optional literal brackets,
            // followed by word characters or space.
            regex.Append(@"\[?[\w\s]+\]?\s?");

            // Add the operators: > < or =.
            regex.Append(@"[><=]");

            //Add optional space followed by optional quote and
            // any character followed by the optional quote.
            regex.Append(@"\s?'?.+'?");

            return regex.ToString();
        }

        private void ResetList() {
            this.ClearItems();
            foreach (T t in originalListValue)
                this.Items.Add(t);
            if (IsSortedCore)
                ApplySortCore(SortPropertyCore, SortDirectionCore);
        }
        public struct SingleFilterInfo {
            internal string PropName;
            internal PropertyDescriptor PropDesc;
            internal Object CompareValue;
            internal FilterOperator OperatorValue;
        }
        // Enum to hold filter operators. The chars
        // are converted to their integer values.
        public enum FilterOperator {
            EqualTo = '=',
            LessThan = '<',
            GreaterThan = '>',
            None = ' '
        }
        internal SingleFilterInfo ParseFilter(string filterPart) {
            SingleFilterInfo filterInfo = new SingleFilterInfo();
            filterInfo.OperatorValue = DetermineFilterOperator(filterPart);

            var filterStringParts =
                filterPart.Split(new char[] {
          (char)filterInfo.OperatorValue });

            filterInfo.PropName =
                filterStringParts[0].Replace("[", "").
                Replace("]", "").Replace(" AND ", "").Trim();

            // Get the property descriptor for the filter property name.
            var filterPropDesc =
                TypeDescriptor.GetProperties(typeof(T))[filterInfo.PropName];

            filterInfo.PropDesc = filterPropDesc ?? throw new InvalidOperationException("Specified property to " +
                    "filter " + filterInfo.PropName +
                    " on does not exist on type: " + typeof(T).Name);

            string comparePartNoQuotes = StripOffQuotes(filterStringParts[1]);
            try {
                var converter =
                    TypeDescriptor.GetConverter(filterPropDesc.PropertyType);
                filterInfo.CompareValue =
                    converter.ConvertFromString(comparePartNoQuotes);
            }
            catch (NotSupportedException) {
                throw new InvalidOperationException("Specified filter" +
                    "value " + comparePartNoQuotes + " can not be converted" +
                    "from string. Implement a type converter for " +
                    filterPropDesc.PropertyType);
            }
            return filterInfo;
        }
        internal FilterOperator DetermineFilterOperator(string filterPart) {
            // Determine the filter's operator.
            if (Regex.IsMatch(filterPart, "[^>^<]="))
                return FilterOperator.EqualTo;
            if (Regex.IsMatch(filterPart, "<[^>^=]"))
                return FilterOperator.LessThan;
            return Regex.IsMatch(filterPart, "[^<]>[^=]") ? FilterOperator.GreaterThan : FilterOperator.None;
        }
        internal static string StripOffQuotes(string filterPart) {
            // Strip off quotes in compare value if they are present.
            if (!Regex.IsMatch(filterPart, "'.+'")) return filterPart;
            var quote = filterPart.IndexOf('\'');
            filterPart = filterPart.Remove(quote, 1);
            quote = filterPart.LastIndexOf('\'');
            filterPart = filterPart.Remove(quote, 1);
            filterPart = filterPart.Trim();
            return filterPart;
        }
        internal void ApplyFilter(SingleFilterInfo filterParts) {
            // Check to see if the property type we are filtering by implements
            // the IComparable interface.
            Type interfaceType =
                TypeDescriptor.GetProperties(typeof(T))[filterParts.PropName]
                .PropertyType.GetInterface("IComparable");

            if (interfaceType == null)
                throw new InvalidOperationException("Filtered property" +
                " must implement IComparable.");

            var results = new List<T>();

            // Check each value and add to the results list.
            foreach (T item in this) {
                if (filterParts.PropDesc.GetValue(item) == null) continue;
                var compareValue = filterParts.PropDesc.GetValue(item) as IComparable;
                var result = compareValue.CompareTo(filterParts.CompareValue);
                if (filterParts.OperatorValue == FilterOperator.EqualTo && result == 0)
                    results.Add(item);
                if (filterParts.OperatorValue == FilterOperator.GreaterThan && result > 0)
                    results.Add(item);
                if (filterParts.OperatorValue == FilterOperator.LessThan && result < 0)
                    results.Add(item);
            }
            ClearItems();
            foreach (T itemFound in results)
                this.Add(itemFound);
        }
        public void RemoveFilter() {
            if (Filter != null) Filter = null;
        }
        #endregion
    }
}
