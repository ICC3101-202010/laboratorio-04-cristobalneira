using System;
namespace Proyecto4Neira
{
    public class Verificacion:MaquinaCentral
    {
        Random rdn = new Random();
        private int partssent;
        private int partsout;
        private double cuality;
        public Verificacion()
        {
            memory = 600;
            code = 4;
            status = "Off";
        }
        public int Verify(int a,bool b)
        {
            int partsgiven = a;
            memory -= partsout;
            if (memory <= 0)
            {
                if (memory <= -1)
                {
                    int memorydiff = memory * (-1);
                    Reboot(b);
                    TurnOn();
                    memory = 600 - memorydiff;
                }
                else
                {
                    Reboot(b);
                    TurnOn();
                    memory = 600;
                }
            }
            partssent = rdn.Next(60, partsgiven);
            memory -= partssent;
            if (memory <= 0)
            {
                if (memory <= -1)
                {
                    int memorydiff = memory * (-1);
                    Reboot(b);
                    TurnOn();
                    memory = 600 - memorydiff;
                }
                else
                {
                    Reboot(b);
                    TurnOn();
                    memory = 600;
                }
            }
            double partssent2 = Convert.ToDouble(partssent);
            double partsgiven2 = Convert.ToDouble(partsgiven);
            cuality += (partssent2 / partsgiven2) * 100;

            partsout = partsgiven - partssent;

            return partssent;
        }
        public int SendPack()
        {
            return partssent;
        }
        public double Cuality(int n)
        {
            return cuality / n;
        }
        public void InfoVerif(int a)
        {
            Console.WriteLine("Machine {3}: Verified= {2}, Sent= {0}, Not used= {1}, Memory= {4}", partssent, partsout,a,code,memory);
        }
    }
}
