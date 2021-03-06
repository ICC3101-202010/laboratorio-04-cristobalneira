﻿using System;
namespace Proyecto4Neira
{
    public class Empaque:MaquinaCentral
    {
        Random rdn = new Random();
        private int partssent;
        private int partsout;
        private double cuality;
        private int partsdelivered;
        public Empaque()
        {
            memory = 600;
            code = 5;
            status = "Off";
        }

        public void Pack(int a,bool b)
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
            partssent = rdn.Next(50, partsgiven);
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
            partsdelivered += a;
            partsout = partsgiven - partssent;
        }
        public double Cuality(int n)
        {
            return cuality / n;
        }
        public int Delivered()
        {
            return partsdelivered;
        }
        public void InfoEmp(int a)
        {
            Console.WriteLine("Machine {3}:, Packed= {2}, Delivered succesfully= {0}, Not used= {1}, Memory= {4}", partssent, partsout,a,code,memory);
        }
    }
}
