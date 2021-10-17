using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_Implicit
{
    #region Celsi
    class Celsius
    {
        public double Degree { get; set; }
        public Celsius(double celsi)
        {
            Degree = celsi;

        }
    }
    #endregion

    #region Kelvin


    class Kelvin
    {
        public double Degree { get; set; }
        public Kelvin(double kelvin)
        {
            Degree = kelvin;
        }
        public static implicit operator Celsius(Kelvin kelvin)
        {
            return new Celsius(kelvin.Degree - 273.15);
        }
    }
    #endregion
}
