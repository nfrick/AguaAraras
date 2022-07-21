using System;
using System.Collections.Generic;
using System.Linq;

namespace DataLayer {
    public static class Extensions {

        public static string ToConcatenatedString(this IEnumerable<string> items, string middleSep = ", ", string finalSep = " e ") {
            switch (items.Count()) {
                case 0: return string.Empty;
                case 1: return items.First();
                case 2: return String.Join(finalSep, items);
                default: return String.Join(middleSep, items.Take(items.Count() - 1)) + finalSep + items.Last();
            }
        }
    }
}
