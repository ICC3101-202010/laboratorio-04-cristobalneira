using System;
namespace Proyecto4Neira
{
    public abstract class MaquinaCentral
    {
        protected int code { get; set; }
        protected int memory { get; set; }
        protected string status { get; set; }
        protected int hour { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Machine {0} Turned On", code);
            status = "On";
        }
        public void TurnOff()
        {
            Console.WriteLine("Machine {0} Turned Off", code);
            status = "Off";
        }
        public void Reboot(bool automatic)
        {
            if (automatic == true)
            {
                Console.WriteLine("Machine {0} is rebooting, there is no more memory left!", code);
                System.Threading.Thread.Sleep(2000);
                status = "Reboot";
            }
            else
            {
                Console.WriteLine("WARNING! Machine {0} has no more memory left!",code);
                Console.WriteLine("Type 'yes' to reboot");
                string a = Console.ReadLine();
                while (a != "yes")
                {
                    Console.WriteLine("Wrong data!");
                    Console.WriteLine("Type 'yes' to rebbot machine {0}?", code);
                    a = Console.ReadLine();
                }

            }
            
        }
    }
}
