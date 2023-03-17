using Computer.Interface;
using Computer.Models;
using System.Xml.Linq;

namespace Computer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hardDrive = new List<HardDrive>();
            hardDrive.Add(new HardDrive("Samsung", "1TB"));
            hardDrive.Add(new HardDrive("Western Digital", "2TB"));
            hardDrive.Add(new HardDrive("Hitachi", "3TB"));


            var ram = new List<RAM>();
            ram.Add(new RAM("Corsair", "1GB"));
            ram.Add(new RAM("Kingston", "1GB"));
            ram.Add(new RAM("G.Skill", "1GB"));
            ram.Add(new RAM("Crucial", "1GB"));
            ram.Add(new RAM("Samsung", "1GB"));
            ram.Add(new RAM("Corsair", "2GB"));
            ram.Add(new RAM("Kingston", "2GB"));
            ram.Add(new RAM("Samsung", "2GB"));

            var processor = new List<Processor>();
            processor.Add(new Processor("Intel", "2Ghz"));
            processor.Add(new Processor("AMD", "2,5Ghz"));


            var computer = new ComputerUser();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hello. You are create the computer. Add device:");
                Console.WriteLine("1 - RAM");
                Console.WriteLine("2 - Hard Drive");
                Console.WriteLine("3 - Processor");
                Console.WriteLine("4 - Look connected device");
                Console.WriteLine("5 - No, thanks, Exit please");
                string selectuser = Console.ReadLine();
                if (selectuser == "5")
                {
                    computer.Dispose();
                    break;
                }
                else
                if (selectuser == "1")
                {
                    Console.WriteLine("Choose:");
                    foreach (var item in ram)
                    {
                        var index = ram.IndexOf(item) + 1;
                        Console.WriteLine(index + " " + item.Name + " " + item.MemorySize);
                    }
                    int selectRam = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in ram)
                    {
                        if (ram.IndexOf(item) == selectRam)
                        {
                            computer.AddDevice(item);
                        }
                    }

                }
                if (selectuser == "2")
                {
                    Console.WriteLine("Choose:");
                    foreach (var item in hardDrive)
                    {
                        var index = hardDrive.IndexOf(item) + 1;
                        Console.WriteLine(index + " " + item.Name + " " + item.MemorySize);
                    }
                    int selectHardDrive= Convert.ToInt32(Console.ReadLine());
                    foreach (var item in hardDrive)
                    {
                        if (hardDrive.IndexOf(item) == selectHardDrive)
                        {
                            computer.AddDevice(item);
                        }
                    }

                }
                if (selectuser == "3")
                {
                    Console.WriteLine("Choose:");
                    foreach (var item in processor)
                    {
                        var index = processor.IndexOf(item) + 1;
                        Console.WriteLine(index + " " + item.Name + " " + item.Frequency);
                    }
                    int selectProcessor = Convert.ToInt32(Console.ReadLine());
                    foreach (var item in processor)
                    {
                        if (processor.IndexOf(item) == selectProcessor)
                        {
                            computer.AddDevice(item);
                        }
                    }

                }
                if (selectuser == "4")
                {
                    var proc = computer.GetProcessor();
                    var listRam = computer.GetAllRAM();
                    var listHD = computer.GetAllHardDrive();
                    Console.WriteLine($" Your processor {proc.Name} {proc.Frequency}");
                    foreach(var item in listRam)
                    {
                        Console.WriteLine($" Your RAM {item.Name} {item.MemorySize}");
                    }
                    foreach (var item in listHD)
                    {
                        Console.WriteLine($" Your RAM {item.Name} {item.MemorySize}");
                    }
                    Console.ReadLine();
                }

            }





        }
    }
}