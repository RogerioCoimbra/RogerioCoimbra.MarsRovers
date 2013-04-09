using System;

namespace RogerioCoimbra.MarsRovers.Common.Attibute
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class CaractereInputOrientationAttribute : Attribute
    {
        public string Caractere { get; private set; }

        public CaractereInputOrientationAttribute(string caractere)
        {
           Caractere = caractere;
        }
    }
}
