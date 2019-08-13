using System.Collections.Generic;
using System.Data.OleDb;

namespace MyNotes {
    static class DataBase {
        private static string _connectionString;

        public static void CreateConnectionString(string name) {
            _connectionString = "Provider = Microsoft.Jet.OLEDB.4.0;" +
                               "Data Source = " + name + ";";
        }

        public static List<object> GetList(string sql, params object[] p) {
            return ExecuteQuery(sql, p);
        }

        public static List<object> ExecuteQuery(string sql, params object[] p) {
            List<object> values = new List<object>();

            using (OleDbConnection connection = new OleDbConnection(_connectionString)) {
                string commandText = string.Format(sql, p);
                OleDbCommand command = new OleDbCommand(commandText, connection);
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read()) {
                    for (int i = 0; i < reader.FieldCount; i++) {
                        values.Add(reader.GetValue(i));
                    }
                }

                reader.Close();
            }

            return values;
        }
    }
}
