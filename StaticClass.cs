using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slide1
{
    public static class StaticClass
    {
        public static float pi = 3.14f;
        public static float g = 9.8f;
        public static float MeterToKilometer(float meter)
        {
            return meter/1000;
        }
    }
}
