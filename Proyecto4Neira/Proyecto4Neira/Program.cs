using System;

namespace Proyecto4Neira
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Recepcion r = new Recepcion();
            Almacenamiento a = new Almacenamiento();
            Ensamblaje en = new Ensamblaje();
            Verificacion v = new Verificacion();
            Empaque em = new Empaque();
            Console.WriteLine("0 quit, 1 automatic program, 2 manual program");
            int ask = Convert.ToInt32(Console.ReadLine());
            //Auto
            if (ask == 1)
            {
                for (int x = 5; x <= 15; x++)
                {
                    Console.WriteLine("Hour: {0}.", x);
                    if (x == 5)
                    {
                        r.TurnOn();
                        a.TurnOn();
                        en.TurnOn();
                        v.TurnOn();
                        em.TurnOn();
                    }
                    else
                    {
                        r.Recieve();
                        int alm = r.SendAlm();
                        r.InfoR();

                        a.LayUp(alm);
                        a.InfoAlm(alm);
                        int ens = a.SendEns();


                        en.Ensamble(ens);
                        en.InfoR(ens);
                        int verf = en.SendVerf();

                        v.Verify(verf);
                        v.InfoVerif(verf);
                        int emp = v.SendPack();

                        em.Pack(emp);
                        em.InfoEmp(emp);
                    }
                }
                r.TurnOff();
                a.TurnOff();
                en.TurnOff();
                v.TurnOff();
                em.TurnOff();
                Console.WriteLine("Total of products delivered: {0} in 10 hours.", em.Delivered());
                Console.WriteLine("Cuality Machine {0}: {1}%", 00100, Math.Round(r.Cuality(10)));
                Console.WriteLine("Cuality Machine {0}: {1}%", 00200, Math.Round(a.Cuality(10)));
                Console.WriteLine("Cuality Machine {0}: {1}%", 00300, Math.Round(en.Cuality(10)));
                Console.WriteLine("Cuality Machine {0}: {1}%", 00400, Math.Round(v.Cuality(10)));
                Console.WriteLine("Cuality Machine {0}: {1}%", 00500, Math.Round(em.Cuality(10)));
            }
            else if (ask == 2)
            {
            }
            Console.WriteLine("Program closed!");
        }
    }
}
