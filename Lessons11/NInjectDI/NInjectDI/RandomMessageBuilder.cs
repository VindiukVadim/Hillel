using NInjectDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI
{
    public class RandomMessageBuilder
    {
        private readonly IDateTimeGenerator _dateTimeGenerator;
        private readonly IGreetingsGenerator _greetingsGenerator;
        private readonly INamesGenerator _nameGenerator;

        public RandomMessageBuilder(IDateTimeGenerator dateTimeGenerator, IGreetingsGenerator greetingsGenerator, INamesGenerator namesGenerator)
        {
            _dateTimeGenerator = dateTimeGenerator;
            _greetingsGenerator= greetingsGenerator;
            _nameGenerator = namesGenerator;
        }

        public string AddDateTime(bool isRandom)
        {
            if (isRandom == true) 
            {
               return _dateTimeGenerator.GetRandomDateTіme();
            }
            else 
            {
               return _dateTimeGenerator.GetCurrentDateTime(); 
            }
        }

        public string AddGreeting()
        {
           return _greetingsGenerator.GetRandomGreetings();
        }

        public string AddName()
        {
           return _nameGenerator.GetRandomName();
        }

    }
}
