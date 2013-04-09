using System;
using System.Linq;
using RogerioCoimbra.MarsRovers.Common.Attibute;

namespace RogerioCoimbra.MarsRovers.Domain
{
    public static class EnumExtensions
    {
        private static T GetAttribute<T>(this Enum objValue) where T : Attribute
        {
            var type = objValue.GetType();
            var field = type.GetField(objValue.ToString());

            return (T)field.GetCustomAttributes(true).FirstOrDefault(c => c is T);
        }

        public static string GetCaractere(this Enum value)
        {
            return value.GetAttribute<CaractereInputOrientationAttribute>().Caractere;
        }
    }
}
