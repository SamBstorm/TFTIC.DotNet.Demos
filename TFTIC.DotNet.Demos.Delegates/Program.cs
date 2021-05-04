using System;

namespace TFTIC.DotNet.Demos.Delegates
{
    delegate void NomDelegate(string text);
    delegate string DelReturnString();
    delegate void ProgramRotor(int angle);
    class Program
    {
        static void Main(string[] args)
        {
            #region Démonstration de base
            //NomDelegate del;

            //del = Console.WriteLine;

            //del("Hello World!");

            //DelReturnString del2;
            //del2 = Console.ReadLine;

            //string toto = del2(); 
            #endregion

            BrasMecanic bm = new BrasMecanic();

            Console.WriteLine($"Rot1{bm.AngleRotor1} - Rot2{bm.AngleRotor2} - Rot3{bm.AngleRotor3} ");

            ProgramRotor pr;
            pr = bm.changeRotor1;
            pr += bm.changeRotor2;
            pr += bm.changeRotor3;
            pr -= bm.changeRotor2;
            pr(30);

            Console.WriteLine($"Rot1{bm.AngleRotor1} - Rot2{bm.AngleRotor2} - Rot3{bm.AngleRotor3} ");
        }
    }

    public class BrasMecanic
    {
        public int AngleRotor1;
        public int AngleRotor2;
        public int AngleRotor3;

        public BrasMecanic()
        {
            AngleRotor1 = 90;
            AngleRotor2 = 70;
            AngleRotor3 = -120;
        }

        public void changeRotor1(int angle)
        {
            changeRotor(1, angle);
        }
        public void changeRotor2(int angle)
        {
            changeRotor(2, angle);
        }
        public void changeRotor3(int angle)
        {
            changeRotor(3, angle);
        }

        public void changeRotor(int numeroRotor, int angle)
        {
            switch (numeroRotor)
            {
                case 1:
                    AngleRotor1 += angle;
                    break;
                case 2:
                    AngleRotor2 += angle;
                    break;
                case 3:
                    AngleRotor3 += angle;
                    break;
                default:
                    throw new Exception("Rotor inconnu");
                    break;
            }
        }
    }
}
