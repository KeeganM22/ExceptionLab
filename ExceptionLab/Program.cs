using System.Security.Cryptography.X509Certificates;

namespace ExceptionLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double positiveR = 100;
            double zeroR = 0;
            double negativeR = -100;

            try
            {
                Circle negitive = new Circle(negativeR);
                Circle zero = new Circle(zeroR);
                Circle positive = new Circle(positiveR);
            }
            catch (InvalidRadiusException e)
            {
                Console.WriteLine("this is an invalid radius, keeping going");
            }
            


            
            
        }
    }
}