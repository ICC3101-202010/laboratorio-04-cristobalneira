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
            Console.WriteLine("Factory opens at 5:00AM and closes at 15:00PM");
            Console.WriteLine("0 quit, 1 automatic program, 2 manual program");
            int ask = Convert.ToInt32(Console.ReadLine());
            //Auto P2
            if (ask == 1)
            {
                bool auto = true;
                for (int x = 5; x <= 15; x++)
                {
                    Console.WriteLine("Hour {0}:", x);
                    if (x == 5)
                    {
                        r.TurnOn();
                        a.TurnOn();
                        en.TurnOn();
                        v.TurnOn();
                        em.TurnOn();
                        Console.WriteLine("All machines has 600 of memory");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        r.Recieve(auto);
                        int alm = r.SendAlm();
                        r.InfoR();

                        a.LayUp(alm,auto);
                        a.InfoAlm(alm);
                        int ens = a.SendEns();


                        en.Ensamble(ens,auto);
                        en.InfoR(ens);
                        int verf = en.SendVerf();

                        v.Verify(verf,auto);
                        v.InfoVerif(verf);
                        int emp = v.SendPack();

                        em.Pack(emp,auto);
                        em.InfoEmp(emp);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                r.TurnOff();
                a.TurnOff();
                en.TurnOff();
                v.TurnOff();
                em.TurnOff();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Total of products delivered: {0} in 10 hours.", em.Delivered());
                Console.WriteLine("Productivity Machine {0}: {1}%", 1, Math.Round(r.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 2, Math.Round(a.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 3, Math.Round(en.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 4, Math.Round(v.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 5, Math.Round(em.Cuality(10)));
            }
            //P4 BONUS
            else if (ask==2)
            {
                bool auto = false;
                for (int x = 5; x <= 15; x++)
                {
                    Console.WriteLine("Hour {0}:", x);
                    if (x == 5)
                    {
                        r.TurnOn();
                        a.TurnOn();
                        en.TurnOn();
                        v.TurnOn();
                        em.TurnOn();
                        Console.WriteLine("All machines has 500 of memory");
                        System.Threading.Thread.Sleep(1000);
                    }
                    else
                    {
                        r.Recieve(auto);
                        int alm = r.SendAlm();
                        r.InfoR();

                        a.LayUp(alm, auto);
                        a.InfoAlm(alm);
                        int ens = a.SendEns();


                        en.Ensamble(ens, auto);
                        en.InfoR(ens);
                        int verf = en.SendVerf();

                        v.Verify(verf, auto);
                        v.InfoVerif(verf);
                        int emp = v.SendPack();

                        em.Pack(emp, auto);
                        em.InfoEmp(emp);
                        System.Threading.Thread.Sleep(2000);
                    }
                }
                r.TurnOff();
                a.TurnOff();
                en.TurnOff();
                v.TurnOff();
                em.TurnOff();
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("Total of products delivered: {0} in 10 hours.", em.Delivered());
                Console.WriteLine("Productivity Machine {0}: {1}%", 1, Math.Round(r.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 2, Math.Round(a.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 3, Math.Round(en.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 4, Math.Round(v.Cuality(10)));
                Console.WriteLine("Productivity Machine {0}: {1}%", 5, Math.Round(em.Cuality(10)));
            }

        Console.WriteLine("Program closed!");
        }
    }
}
