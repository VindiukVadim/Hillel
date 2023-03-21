using DatabaseEngine.Model;

namespace DatabaseEngine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pass = PasswordGenerator.Generate(8);
        }
    }
}