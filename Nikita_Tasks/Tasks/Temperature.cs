using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Temperature
    {
        public delegate int ToCelsius(int farenheit);
        public static ToCelsius convert = (temperature) => temperature = (temperature - 32) * 5 / 9;
    }
}
