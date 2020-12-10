using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    public class Decision
    {
        public int x;
        public int y;

        int k1 = 1;
        int k2 = 50;

        /// <summary>
        /// Function "GetCoordinates" asks the user to enter the data K to satisfy the inequality condition, then enter the coordinates. 
        /// If the condition is not met, an error is displayed.
        /// </summary>
        public void GetCoordinates()
        {
            Console.WriteLine($"Please input К:");

            int k = 0;

            CheckedErrors(Int32.TryParse(Console.ReadLine(), out k));

            Console.WriteLine($"K = {k}");

            Console.WriteLine($"Enter the value X: {x} Enter the value Y: {y}");

            if (k < k1 || k > k2)
            {
                Console.WriteLine("Enter the correct data.");
            }
            else
            {
                //do something.
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Function "CheckedErrors" checks for errors and if an error is found, a message is displayed to the user.
        /// </summary>

        public void CheckedErrors(bool result)
        {
            if (!result)
            {
                Console.WriteLine("It's error.");
            }
        }

        /// <summary>
        /// Function "GetInputData" asks the user to enter input data to continue the request.
        /// </summary>
        public void GetInputData()
        {
            int n1 = 1;
            int n2 = 100;

            Console.WriteLine($"Please input N:");

            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"N = {n}");

            if (n < n1 || n > n2)
            {
                Console.WriteLine("Enter the correct data.");
            }
            else
            {
                double a, b, c;
                Console.WriteLine("Enter a: ");
                a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter b: ");
                b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter c: ");
                c = Convert.ToDouble(Console.ReadLine());
            }
            Console.ReadKey();
        }

        private double a;
        private double b;
        private double c;
        private double w;

        /// <summary>
        /// Function "GetVariables" refers to the current instance of the class, and is also used as a modifier for the first parameter of the extension method.
        /// </summary>
        public void GetVariables(double a, double b, double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;

            Console.ReadKey();
        }
        /// <summary>
        /// Function "Calculation" calculates a quadratic equation. Since the form in the task was not declared, I decided to interpret the search for the value of W through the equation.
        /// </summary>
        public void Calculation()
        {
            w = (Math.Pow(a, 5) - Math.Pow(a, 3) * Math.Sqrt(b)) / (2 * c);
            Console.WriteLine("Result: {0}", w);
            Console.ReadKey();
            MyPoint point_new = new MyPoint(1, 5);
        }
    }
}
