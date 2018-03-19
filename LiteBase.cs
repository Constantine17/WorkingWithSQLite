//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data;
//using System.Data.SQLite;
//using System.Data.Common;

//namespace WorkingWithSQLite
//{
//    // 
//    class LiteBase 
//    {
//        protected struct Worker
//        {
//            public Int64 id;
//            public string name;
//            public string code;
//            public double selary;
//            public Guid guid;
//        }


//        protected string connectionString;
//        protected string directory;
//        protected List<Worker> workers = new List<Worker>();

//        public LiteBase(string directory)
//        {
//            this.connectionString = "Data Source = " + directory;
//            this.directory = directory;
//        }

//        /// <summary>
//        /// Создание таблицы в базе данных
//        /// </summary>
//        public void Craete()
//        {
//            string stringConnection = connectionString;

//            SQLiteConnection.CreateFile(directory);

//            SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
//            using (SQLiteConnection connection = (SQLiteConnection)factory.CreateConnection())
//            {
//                connection.ConnectionString = "Data Source = " + directory;
//                connection.Open();

//                using (SQLiteCommand command = new SQLiteCommand(connection))
//                {
//                    //command.CommandText = @"CREATE TABLE [workers] (
//                    //[id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
//                    //[name] char(100) NOT NULL,
//                    //[family] char(100) NOT NULL,
//                    //[age] int NOT NULL,
//                    //[profession] char(100) NOT NULL
//                    //);";
//                    command.CommandText = @"CREATE TABLE [workers] (
//                    [id] integer PRIMARY KEY AUTOINCREMENT NOT NULL,
//                    [name] text NOT NULL,
//                    [code] char(10),
//                    [selary] real,
//                    [guid] blob
//                    );";
//                    command.CommandType = CommandType.Text;
//                    command.ExecuteNonQuery();
//                }
//            }
//        }

//        public void Insert()
//        {
//            string stringConnection = connectionString;

//            //SQLiteConnection.CreateFile(stringConnection);

//            //SQLiteFactory factory = (SQLiteFactory)DbProviderFactories.GetFactory("System.Data.SQLite");
//            using (SQLiteConnection connection = new SQLiteConnection(stringConnection))
//            {
//                connection.Open();

//                using (SQLiteCommand command = new SQLiteCommand(connection))
//                {
//                    for (int i = 11; i <= 20; i++) // автозополнение таблийцы
//                    {
//                        //command.CommandText = @"Insert into [workers] ([id], [name], [code], [selary]) values (1, 'test', 'dd', 1000)";
//                        command.CommandText = @"Insert into [workers] ([id], [name], [code], [selary], [guid]) values ("+i+", 'test"+ i + "', '"+i+"', "+i.GetHashCode()+", " +  Guid.NewGuid().ToByteArray()+ ")";
//                        command.CommandType = CommandType.Text;
//                        command.ExecuteNonQuery();
//                    }
//                }
//            }
//        }

//        public void Select()
//        {
//            string sqlReaqest = "Select * From [workers] ";
//            workers.Clear();

//            using (var Connection = new SQLiteConnection(connectionString))
//            {
//                using (SQLiteCommand command = new SQLiteCommand(sqlReaqest, Connection))
//                {
//                    //
//                    Connection.Open();
//                    SQLiteDataReader reader = command.ExecuteReader();
                    
//                    while (reader.Read())
//                    {
//                        Worker worker = new Worker();
//                        worker.id = (Int64)reader["id"];
//                        worker.name = (string)reader["name"];
//                        worker.code = (string)reader["code"];
//                        worker.selary = (double)reader["selary"];

//                        workers.Add(worker);
//                    }
//                    //Connection.Close();
//                }
//            }
//        }
//    }
//}
