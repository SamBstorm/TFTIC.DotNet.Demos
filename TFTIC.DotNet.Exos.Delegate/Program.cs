using System;

namespace TFTIC.DotNet.Exos.Delegate
{
    public delegate void MouvementRobot();
    class Program
    {
        static void Main(string[] args)
        {
            Robot r = new Robot();

            MouvementRobot mr;
            mr = r.Avancer;
            mr += r.TournerGauche;
            mr += r.Avancer;
            mr += r.TournerDroite;
            mr += r.Avancer;
            mr += r.TournerGauche;
            mr += r.Avancer;
            mr += r.TournerDroite;
            mr += r.Avancer;
            mr += r.TournerDroite;
            mr += r.Avancer;
            mr += r.Avancer;

            mr();

        }
    }
}
