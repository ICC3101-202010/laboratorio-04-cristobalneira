using System;
namespace Proyecto4Neira
{
    public class Empaque:Maquina
    {
        Random rdn = new Random();
        private int partssent;
        private int partsout;
        private double cuality;
        private int partsdelivered;
        public Empaque()
        {
            memory = 500;
            code = 00500;
            status = "Off";
        }
        public void Pack(int a)
        {
            int partsgiven = a;
            memory -= partsout;
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
            partssent = rdn.Next(95, partsgiven);
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
            cuality += partssent / partsgiven;
            partsdelivered += a;
            partsout = partsgiven - partssent;
        }
        public double Cuality(int n)
        {
            return cuality / n;
        }
        public void InfoEmp()
        {
            Console.WriteLine("Delivered succesfully= {0}, Not used= {1}", partssent, partsout);
        }
    }
}
