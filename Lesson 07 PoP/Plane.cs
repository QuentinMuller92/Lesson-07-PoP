using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_PoP
{
    public class Plane : IVehicle
    {
        public string RegistrationNumber
        {
            get; set;
        }

        public int Year
        {
            get; set;
        }

        public int NumberOfWings { get; set; }
    }
}
