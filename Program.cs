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
           // var lbase = new LiteBase(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.db3");
           // var lbaseLinq = new LiteBaseForLINQ(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.db3");
            //string str = "";
            //lbaseLinq.Craete();
            //lbase.Craete();
            //lbase.Insert();
            //lbase.Select();
            //using (var db = new SQLiteConnection(@"F:\project\WorkingWithSQLite\WorkingWithSQLite\DB\db1.3bd"))
            //{
            //    var vr = db.CreateCommand();
            //    vr.ExecuteNonQuery()
            //}
            //Console.WriteLine(Convert.ToInt64(Guid.NewGuid().ToByteArray()));
            string date = @"01/31/18 02:08 PM";
            //Console.WriteLine(DateTime.Parse(;
            //Console.WriteLine(DateTime.Now.ToString(@"MM/dd/yy hh:mm tt"));
            Console.WriteLine(DateTime.ParseExact(@"01/31/18 02:08 PM", @"MM/dd/yy hh:mm tt", System.Globalization.CultureInfo.InvariantCulture));
            Console.ReadLine();
        }


    }
}
