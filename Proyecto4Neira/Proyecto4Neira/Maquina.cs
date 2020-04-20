using System;
namespace Proyecto4Neira
{
    public abstract class Maquina
    {
        protected int code { get; set; }
        protected int memory { get; set; }
        protected string status { get; set; }
        protected int hour { get; set; }
        protected void TurnOn()
        {
            Console.WriteLine("Machine {0} Turned On", code);
            status = "On";
        }
        protected void TurnOff()
        {
            Console.WriteLine("Machine {0} Turned Off", code);
            status = "Off";
        }
        protected void Reboot()
        {
            Console.WriteLine("No more memory!, machine {0} is rebooting", code);
            status = "Reboot";
        }
    }
}
