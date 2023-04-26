﻿using NInjectDI.Interfaces;
using System;
using System.Text;

namespace NInjectDI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var newRandomMessage = new RandomMessageBuilder(new DataTimeGenerator(), new GreetingsGenerator(), new NamesGenerator());
            var resultString = new StringBuilder();
            resultString.Append(newRandomMessage.AddDateTime(false)+" ");
            resultString.Append(newRandomMessage.AddGreeting()+" ");
            resultString.Append(newRandomMessage.AddName()+" ");
            Console.WriteLine(resultString);
            Console.ReadLine();
           
        }
    }
}

