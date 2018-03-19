using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        
    }
}
