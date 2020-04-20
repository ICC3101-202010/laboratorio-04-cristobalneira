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
            cuality = 0;
            memory = 500;
            code = 00100;
            status = "Off";
        }
        public void Recieve()
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
            double partssent2 = Convert.ToDouble(partssent);
            double partsgiven2 = Convert.ToDouble(partsgiven);
            cuality += (partssent2/partsgiven2)*100;
            partsout = partsgiven - partssent;

        }
        public int SendAlm()
        {
            return partssent;
        }

        public double Cuality(int n)
        {
            return cuality / n;
        }
        public void InfoR()
        {
            Console.WriteLine("Machine {2}: Recieved= {3}, Sent= {0}, Not used= {1}, Memory= {4}", partssent, partsout,code,partssent + partsout, memory);
        }
    }
}