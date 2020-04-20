using System;
namespace Proyecto4Neira
{
    public abstract class Maquina
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
        public void Reboot()
        {
            Console.WriteLine("Machine {0} is rebooting, there is no more memory left!", code);
            status = "Reboot";
        }
    }
}
