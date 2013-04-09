using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerioCoimbra.MarsRovers.Domain.Model
{
    public class Rover
    {
        public int XCoordinate { get; private set; }
        public int YCoordinate { get; private set; }
        public Orientation Orientation { get; private set; }
        public Plateau Plateau { get; private set; }

        public Rover(int xCoordinate, int yCoordinate, Orientation orientation, Plateau plateau)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
            Orientation = orientation;
            Plateau = plateau;
        }

        public string GetCurrentPosition()
        {
            return String.Format("{0} {1} {2}", XCoordinate.ToString(), YCoordinate.ToString(), Orientation.GetCaractere());
        }

        public Rover Navigate(string commands)
        {
            foreach (var command in commands)
            {
                switch (command)
                {
                    case ('L'):
                        TurnLeft();
                        break;
                    case ('R'):
                        TurnRight();
                        break;
                    case ('M'):
                        Move();
                        break;
                    default:
                        throw new ArgumentException(string.Format("Invalid command: {0}", command));
                }
            }

            return this;
        }

        private void TurnLeft()
        {
            Orientation = (Orientation - 1) < Orientation.North ? Orientation.West : Orientation - 1;
        }

        private void TurnRight()
        {
            Orientation = (Orientation + 1) > Orientation.West ? Orientation.North : Orientation + 1;
        }

        /// <remarks>
        /// Não permiti que a sonda saísse da planície.
        /// Quando ela chega à borda e a direção esta para fora eu anulo o movimento.
        /// </remarks>
        private void Move()
        {
            switch (Orientation)
            {
                case Orientation.North:
                    if (Plateau.IsRoverInsideBoundaries(XCoordinate, YCoordinate + 1))
                        YCoordinate++;
                    break;
                case Orientation.East:
                    if (Plateau.IsRoverInsideBoundaries(XCoordinate + 1, YCoordinate))
                        XCoordinate++;
                    break;
                case Orientation.South:
                    if (Plateau.IsRoverInsideBoundaries(XCoordinate, YCoordinate - 1))
                        YCoordinate--;
                    break;
                case Orientation.West:
                    if (Plateau.IsRoverInsideBoundaries(XCoordinate - 1, YCoordinate))
                        XCoordinate--;
                    break;
            }
        }
    }
}
