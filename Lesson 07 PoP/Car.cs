using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lesson_07_PoP.Enums;

namespace Lesson_07_PoP
{
    public class Car : IVehicle
    {
        private string colorName;

        private int year;

        public string RegistrationNumber { get; set; }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                if (value >= 1900 && value <= 2050)
                {
                    year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Make Make { get; set; }

        public Model Model { get; set; }

        public Color Color { get; set; }

        public string ColorName
        {
            get
            {
                switch (Color)
                {
                    case Color.other:
                        return colorName;

                    default:
                        return Color.ToString();
                }
            }
            set
            {
                if (value.Length <= 10)
                {
                    colorName = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public override string ToString()
        {
            return $"{Make,-10} {Model,-10} {Color,-10} Year:{Year} Reg.No:{RegistrationNumber} ";
        }
    }
}
