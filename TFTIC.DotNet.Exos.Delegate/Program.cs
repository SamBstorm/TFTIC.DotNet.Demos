using System;

namespace TFTIC.DotNet.Exos.Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot r = new Robot();
            r.AddMouvement(Robot.Movement.Avancer);
            r.AddMouvement(Robot.Movement.Gauche, Robot.Movement.Avancer, Robot.Movement.Droite);
            r.StartMouvement();
        }
    }
}
