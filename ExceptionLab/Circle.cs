using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLab
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {

            Radius = radius;

        }

        public void setRadus(double radus)
        {
            if (radus > 0)
            {
                Radius = radus;
            }
            else
            {
                throw new InvalidRadiusException();
            }
        }
        public override string ToString()
        {
            return Radius.ToString();
        }
    }
}
