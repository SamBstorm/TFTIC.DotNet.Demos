using System;
using System.Collections.Generic;
using System.Text;

namespace TFTIC.DotNet.Exos.Delegate
{
    //public delegate void MouvementRobot();
    public enum Direction { Haut, Droite, Bas, Gauche }
    public class Robot
    {
        public enum Movement { Gauche, Avancer, Droite }
        private int Position_X;
        private int Position_Y;
        private int _direction_angle;
        private Action _mr;

        private Direction Direction
        {
            get
            {
                Direction d = Direction.Haut;
                switch (_direction_angle % 360)
                {
                    case -270:
                    case 90:
                        d = Direction.Droite;
                        break;
                    case -180:
                    case 180:
                        d = Direction.Bas;
                        break;
                    case -90:
                    case 270:
                        d = Direction.Gauche;
                        break;
                }
                return d;
            }
        }

        public Robot()
        {
            Position_X = Position_Y = 0;
            _direction_angle = 90;
            _mr = null;
        }

        private void Avancer()
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
        private void TournerGauche()
        {
            _direction_angle -= 90;
            Console.WriteLine(this);
        }
        private void TournerDroite()
        {
            _direction_angle += 90;
            Console.WriteLine(this);
        }

        public void AddMouvement(Movement action)
        {
            switch (action)
            {
                case Movement.Gauche:
                    _mr += TournerGauche;
                    break;
                case Movement.Avancer:
                    _mr += Avancer;
                    break;
                case Movement.Droite:
                    _mr += TournerDroite;
                    break;
                default:
                    break;
            }
        }
        public void AddMouvement(params Movement[] actions)
        {
            foreach (Movement action in actions)
            {
                switch (action)
                {
                    case Movement.Gauche:
                        _mr += TournerGauche;
                        break;
                    case Movement.Avancer:
                        _mr += Avancer;
                        break;
                    case Movement.Droite:
                        _mr += TournerDroite;
                        break;
                    default:
                        break;
                }
            }
        }

        public void StartMouvement()
        {
            _mr();
        }

        //virtual string ToString() => Return NomNameSpace.NomObject //TFTIC.DotNet.Exos.Delegate.Robot
        public override string ToString()
        {
            return $"Pos X: {this.Position_X} - Y : {this.Position_Y} | Direction : {this.Direction}";
        }
    }
}
