using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionLab
{
    internal class InvalidRadiusException : Exception
    {
        /*Public override string Message
        {
            get
            {
                return "Invalid Rad";
            }
        }*/
        public InvalidRadiusException() : base("Invalid Radius") // doing this allows for a custom message
        {
            

        }

        public InvalidRadiusException(double radius) : base("invalid radius " +  radius)
        {
            

        }
    }
}
