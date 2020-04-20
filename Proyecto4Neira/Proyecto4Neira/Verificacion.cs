﻿using System;
namespace Proyecto4Neira
{
    public class Verificacion:Maquina
    {
        Random rdn = new Random();
        private int partssent;
        private int partsout;
        private double cuality;
        public Verificacion()
        {
            memory = 500;
            code = 00400;
            status = "Off";
        }
        public int Verify(int a)
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
        public void InfoVerif()
        {
            Console.WriteLine("Sent= {0}, Not used= {1}", partssent, partsout);
        }
    }
}