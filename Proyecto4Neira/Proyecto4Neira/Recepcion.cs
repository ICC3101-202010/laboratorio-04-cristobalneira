using System;
namespace Proyecto4Neira
{
    public class Recepcion : Maquina
    {
        Random rdn = new Random();
        private int partssent;
        private int partsout;
        private double cuality;
        public Recepcion()
        {
            memory = 500;
            code = 00100;
            status = "Off";
        }
        public int SendAlm()
        {
            int partsgiven = rdn.Next(100, 110);
            memory -= partsout;
            if (memory <= 0)
            {
                if (memory <= -1)
                {
                    int memorydiff = memory * (-1);
                    Reboot();
                    TurnOn();
                    memory = 500-memorydiff;
                }
                else
                {
                    Reboot();
                    TurnOn();
                    memory = 500;
                }
            }
            partssent = rdn.Next(99, partsgiven);
            memory -= partssent;
            if (memory <= 0)
            {
                if (memory <= -1)
                {
                    int memorydiff = memory * (-1);
                    Reboot();
                    TurnOn();

                    memory = 500 - memorydiff;
                }
                else
                {
                    Reboot();
                    TurnOn();
                    memory = 500;
                }
            }
            cuality += partssent/partsgiven;

            partsout = partsgiven - partssent;

            return partssent;
        }
        public double Cuality(int n)
        {
            return cuality / n;
        }
        public void InfoR()
        {
            Console.WriteLine("Machine {2}: Sent= {0}, Not used= {1}", partssent, partsout,code);
        }
    }
}