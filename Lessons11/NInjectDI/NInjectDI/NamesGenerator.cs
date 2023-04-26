using NInjectDI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI
{
    public class NamesGenerator : INamesGenerator
    {
        public string[] names = {"Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "Hannah"};
        public string GetRandomName()
        {
            var Random = new Random();

            return names[Random.Next(names.Length)];
        }
    }
}
