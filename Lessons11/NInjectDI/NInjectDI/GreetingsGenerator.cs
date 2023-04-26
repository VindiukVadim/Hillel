using NInjectDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI
{
    public class GreetingsGenerator: IGreetingsGenerator
    {
        public string[] greetings = { "Hello", "Bonjur", "Salut", "Gamardjoba", "Ahoj", "Cao"};
        public string GetRandomGreetings()
        {
            var Random = new Random();

            return greetings[Random.Next(greetings.Length)];
        }

    }
}
