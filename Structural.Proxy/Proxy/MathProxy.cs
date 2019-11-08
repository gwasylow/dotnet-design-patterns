using Structural.Proxy.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Math = Structural.Proxy.Subject.Math;

namespace Structural.Proxy.Proxy
{
    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    class MathProxy : IMath
    {
        private Structural.Proxy.Subject.Math _math = new Math();

        public double Add(double x, double y)
        {
            return _math.Add(x, y);
        }

        public double Sub(double x, double y)
        {
            return _math.Sub(x, y);
        }

        public double Mul(double x, double y)
        {
            return _math.Mul(x, y);
        }

        public double Div(double x, double y)
        {
            return _math.Div(x, y);
        }
    }
}
