using Ninject;
using NInjectDI.Interfaces;
using System;
using System.Text;

namespace NInjectDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var module = new MessageModule();
            var kernel = new StandardKernel(module);

            var message = kernel.Get<RandomMessageBuilder>();
            var result = new StringBuilder();
            result.Append(message.AddDateTime(true) + " ");
            result.Append(message.AddGreeting() + " ");
            result.Append(message.AddName() + " ");
            Console.WriteLine(result);
            Console.ReadLine();
           
        }
    }
}

