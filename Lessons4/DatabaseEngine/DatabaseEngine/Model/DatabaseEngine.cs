using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Model
{
    public class DatabaseEngine<T>
    {
        public class DatabaseValue
        {
            public T Value { get; set; }
            public string TableName { get; set; }
        }

        public void WriteValue (T value, string password)
        {
            DatabaseValue database=new DatabaseValue ();
            database.Value = value;
            database.TableName = password;
        }
    }
}
