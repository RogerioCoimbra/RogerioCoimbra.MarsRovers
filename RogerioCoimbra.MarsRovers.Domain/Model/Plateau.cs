using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogerioCoimbra.MarsRovers.Domain.Model
{
    public class Plateau
    {
        public int UpperRightCoordinates { get; private set; }
        public int LeftRightCoordinates { get; private set; }

        public Plateau(int upperRightCoordinates, int leftRightCoordinates)
        {
            UpperRightCoordinates = upperRightCoordinates;
            LeftRightCoordinates = leftRightCoordinates;
        }

        public bool IsRoverInsideBoundaries(int xCoordinate, int yCoordinate)
        {
            return
                yCoordinate.IsBetween(0, UpperRightCoordinates) &&
                xCoordinate.IsBetween(0, LeftRightCoordinates);
        }
    }
}
