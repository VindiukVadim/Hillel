using Computer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Models
{
    internal class ComputerUser:IDisposable
    {
        private List<RAM> ramSlots = new List<RAM>(4);
        private List<HardDrive> hardDriveSlots= new List<HardDrive>(2);
        private Processor processorSlot;

        public List<RAM> GetAllRAM()
        {
            return ramSlots.ToList();
        }
        public List<HardDrive> GetAllHardDrive()
        {
            return hardDriveSlots.ToList();
        }
        public Processor GetProcessor()
        {
            return processorSlot;
        }

        public void AddDevice(IDevice device)
        {
            if (device is RAM)
            {
                if (ramSlots.Count < 4)
                {
                    ramSlots.Add((RAM)device);
                    Console.WriteLine("Add RAM");
                }
                else
                {
                    Console.WriteLine("No free memory slot");
                    Console.ReadLine();
                }

            }
            else if (device is HardDrive)
            {
                if (ramSlots.Count < 2)
                {
                    hardDriveSlots.Add((HardDrive)device);
                    Console.WriteLine("Add Hard Drive");
                } else 
                {
                    Console.WriteLine("No free HD slot");
                    Console.ReadLine();
                }
            }
            else if (device is Processor)
            {
                if (processorSlot == null)
                {
                    processorSlot = (Processor)device;
                    Console.WriteLine("Add Hard Drive");
                } else
                {
                    Console.WriteLine("No free processor slot");
                    Console.ReadLine();
                }

            }
        }

        public void Dispose()
        {
            Console.WriteLine("Disposing computer");
            foreach (RAM ram in ramSlots)
            {
                ram.Eject();
            }
            ramSlots.Clear();
            foreach (IHardDrive hardDrive in hardDriveSlots)
            {
                hardDrive.Remove();
            }
            hardDriveSlots.Clear();
            if (processorSlot != null)
            {
                processorSlot.Unplug();
                processorSlot = null;
            }
        }

        ~ComputerUser()
        {
            Console.WriteLine("Destruct the computer");
            Dispose();
        }

    }
}
