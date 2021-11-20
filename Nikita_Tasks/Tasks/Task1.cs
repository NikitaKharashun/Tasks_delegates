using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikita_Tasks.Tasks
{
    class Task1
    {
        public static Func<int, double> ToCelsius  = (temperature) => temperature = (temperature - 32) * 5 / 9;
    }
}
