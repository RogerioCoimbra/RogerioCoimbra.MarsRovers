using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RogerioCoimbra.MarsRovers.Common.Attibute;

namespace RogerioCoimbra.MarsRovers.Domain.Model
{
    public enum Orientation
    {
        [CaractereInputOrientation("N")]
        North = 0,

        [CaractereInputOrientation("E")]
        East = 1,

        [CaractereInputOrientation("S")]
        South = 2,

        [CaractereInputOrientation("W")]
        West = 3
    }
}
