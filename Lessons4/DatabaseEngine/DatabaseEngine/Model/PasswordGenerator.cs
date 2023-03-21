using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseEngine.Model
{
    public static class PasswordGenerator
    {
        private  static readonly char[] allowedSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToArray();
        public static string Generate(int length)
        {
            var random = new Random();
            var password = new char[length];

            for (var i = 0; i < length; i++)
            {
                password[i] = allowedSymbols[random.Next(allowedSymbols.Length)];
            }

            return new string(password);
        }
    }
}
