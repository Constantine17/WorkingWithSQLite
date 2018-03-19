using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.Common;
using System.Data.SQLite;
using System.Data;



namespace WorkingWithSQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            var lbase = new LiteBase(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.3bd");
            var lbaseLinq = new LiteBaseForLINQ(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.3bd");
            string str = "";
            lbaseLinq.Craete();
            //lbase.Craete();
            //lbase.Insert();
            //lbase.Select();
            //using (var db = new SQLiteConnection(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.3bd"))
            //{
            //    var vr = db.CreateCommand();
            //    vr.ExecuteNonQuery()
            //}
            //Console.WriteLine(Convert.ToInt64(Guid.NewGuid().ToByteArray()));
            
        }


    }
}
