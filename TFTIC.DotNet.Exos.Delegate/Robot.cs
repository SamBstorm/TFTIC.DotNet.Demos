using System;
using System.Collections.Generic;
using System.Text;

namespace TFTIC.DotNet.Exos.Delegate
{
    public enum Direction { Haut, Droite, Bas, Gauche }
    public class Robot
    {
        public int Position_X;
        public int Position_Y;
        private int _direction_angle;

        public Direction Direction
        {
            get
            {
                Direction d = Direction.Haut;
                switch (_direction_angle % 360)
                {
                    case -270:
                    case 90:
                        d= Direction.Droite;
                        break;
                    case -180:
                    case 180: 
                        d= Direction.Bas;
                        break;
                    case -90:
                    case 270: 
                        d= Direction.Gauche;
                        break;
                }
                return d;
            }
        }

        public Robot()
        {
            Position_X = Position_Y = 0;
            _direction_angle = 90;
        }

        public void Avancer()
        {
            switch (this.Direction)
            {
                case Direction.Haut:
                    Position_Y += 1;
                    break;
                case Direction.Bas:
                    Position_Y -= 1;
                    break;
                case Direction.Gauche:
                    Position_X -= 1;
                    break;
                case Direction.Droite:
                    Position_X += 1;
                    break;
            }
            Console.WriteLine(this);
        }
        public void TournerGauche()
        {
            _direction_angle -= 90;
            Console.WriteLine(this);
        }
        public void TournerDroite()
        {
            _direction_angle += 90;
            Console.WriteLine(this);
        }

        //virtual string ToString() => Return NomNameSpace.NomObject //TFTIC.DotNet.Exos.Delegate.Robot

        public override string ToString()
        {
            return $"Pos X: {this.Position_X} - Y : {this.Position_Y} | Direction : {this.Direction}";
        }
    }
}
