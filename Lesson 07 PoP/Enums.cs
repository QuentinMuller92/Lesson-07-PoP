using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_07_PoP
{
    public class Enums
    {
        public enum Make
        {
            Toyota,
            Ford,
            Renault,
            Peugeot
        }

        public enum Model
        {
            Civic,
            Camry,
            Corolla,
            Focus,
            Escape,
            Megane,
            _406,
            _306
        }

        public enum Color
        {
            Red = 1,
            Blue = 2,
            Yellow = 3,
            other = 0
        }
    }
}
