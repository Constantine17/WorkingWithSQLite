using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite.Linq;
using System.Data.SQLite;
using System.Data.Common;

namespace WorkingWithSQLite
{
    class LiteBaseForLINQ : LiteBase
    {
        public LiteBaseForLINQ(string directory) : base(directory)
        {
        }

        public void Craete()
        {
            Console.WriteLine(this.directory);
        }

        public void Select()
        {
            //string sqlReaqest = "Select * From [workers] ";
            workers.Clear();

            using (var Connection = new SQLiteConnection(connectionString))
            {
                //Connection.Open();

                //using (SQLiteCommand command = new SQLiteCommand(sqlReaqest, Connection))
                using (SQLiteCommand command = new SQLiteCommand(Connection))
                {
                    //
                    //var ff = from c in Connection
                    //SQLiteDataReader reader = command.ExecuteReader();


                    //while (reader.Read())
                    //{
                    //    Worker worker = new Worker();
                    //    worker.id = (Int64)reader["id"];
                    //    worker.name = (string)reader["name"];
                    //    worker.code = (string)reader["code"];
                    //    worker.selary = (double)reader["selary"];

                    //    workers.Add(worker);
                    //}
                    //Connection.Close();
                }
            }
        }
    }
}
