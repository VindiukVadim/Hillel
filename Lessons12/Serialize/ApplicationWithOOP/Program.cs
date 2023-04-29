using Serialaze;
using Serialaze.Models;



namespace Serialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            var obj = new Person();


            var xmlSerialize = new XML<Person>();
            var xmlResult = xmlSerialize.Serialize(obj);
            Console.WriteLine("XML SERIALIZE");
            Console.WriteLine(xmlResult);
            obj = xmlSerialize.DeSerialize(xmlResult);

            //***************
            var jsonSerialize = new JsonSerialize<Person>();
            var jsonResult = jsonSerialize.Serialize(obj);
            Console.WriteLine("JSON SERIALIZE");
            Console.WriteLine(jsonResult);
            obj = jsonSerialize.Deserialize(jsonResult);


            Console.ReadLine();


        }
    }
}