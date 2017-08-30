using System.Data.SqlClient;

namespace AguaAraras {
    public abstract class BaseData {
        public int ID { get; set; }
        public bool IsNew => (ID == 0);
        public bool Updated { get; set; }

        protected BaseData() {
            ID = 0;
            Updated = false;
        }

        protected BaseData(SqlDataReader r) {
            ID = (int)r["ID"];
            Updated = false;
        }
    }
}
