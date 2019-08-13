using System.Collections.Generic;

namespace MyNotes {
    abstract class Element {
        protected string TableName;
        protected string RowIdText;
        protected string RowNameText;
        protected ItemCollection items;
        private int lastIdNum;

        public ItemCollection Items { get { return items; } }
        protected int LastID { get { return lastIdNum; } }

        protected Element(string tableName) {
            this.TableName = tableName;
            RowIdText = "ID";
            RowNameText = "Name";
            items = new ItemCollection();

            LoadData();
        }

        private void LastId() {
            if (lastIdNum == 0) {
                const string queryString = "SELECT MAX({0}) FROM {1}";
                List<object> queryResult = DataBase.GetList(queryString, RowIdText, TableName);

                lastIdNum = (int)queryResult[0];
            } else {
                lastIdNum++;
            }
        }

        protected void Add(params string[] args) {
            if (args.Length % 2 != 0 || args.Length <= 0) {
                return;
            }

            const string delimeter = ", ";
            string rows = "";
            string values = "";
            int currentIndex = 0;

            while (true) {
                rows += args[currentIndex++];
                values += args[currentIndex++];

                if (currentIndex >= args.Length) {
                    break;
                }

                rows += delimeter;
                values += delimeter;
            }

            const string query = "INSERT INTO {0} ({1}) VALUES ({2});";
            DataBase.ExecuteQuery(query, TableName, rows, values);

            LastId();
        }

        protected void Parse(string sql, params string[] p) {
            List<object> list = DataBase.GetList(sql, p);
            items = new ItemCollection();

            int currentIndex = 0;

            while (currentIndex < list.Count) {
                int id = (int)list[currentIndex++];
                string content = list[currentIndex++].ToString();

                items.Add(id, content);
            }
        }

        public bool Add(string text) {
            if (text == null || text.Length <= 0) {
                return false;
            }

            text = text.Trim(' ', '\n').Replace('\'', '"');
            Add(RowNameText, '\'' + text + '\'');
            items.Add(LastID, text);

            return true;
        }

        public void Delete(int id) {
            int index = items.FindIndex(id);

            if (items.RangeEntry(index)) {
                const string queryString = "DELETE FROM {0} WHERE {1} = {2};";
                DataBase.ExecuteQuery(queryString, TableName, RowIdText, id);

                items.RemoveAt(index);
            }
        }

        public void Update(int id, params string[] args) {
            string values = "";
            int currentIndex = 0;

            while (currentIndex < args.Length) {
                values += args[currentIndex++] + " = " + args[currentIndex++];

                if (currentIndex != args.Length) {
                    values += ", ";
                }
            }

            const string queryString = "UPDATE {0} SET {1} WHERE {2} = {3};";
            DataBase.ExecuteQuery(queryString, TableName, values, RowIdText, id);
        }

        public void LoadData() {
            const string queryString = "SELECT {0}, {1} FROM {2};";
            Parse(queryString, RowIdText, RowNameText, TableName);
        }
    }

    class Classifications : Element {
        public Classifications(string tableName)
            : base(tableName) { }
    }

    class Authors : Element {
        public Authors(string tableName)
            : base(tableName) { }
    }

}
