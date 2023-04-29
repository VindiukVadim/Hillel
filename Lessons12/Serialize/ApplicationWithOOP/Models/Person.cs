using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialaze.Models
{
    [Serializable]
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public int Age { get; set; }

        public Person() 
        {
            Id = 1;
            FirstName = "Vasy";
            SecondName = "Vasilev";
            Age = 18;
        }
    }
}
