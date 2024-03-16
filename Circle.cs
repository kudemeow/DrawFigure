using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Circle : IFigure
    {
        public void Draw()
        {
            Console.Write("Please enter radius of the circle: ");

            double r = Convert.ToDouble(Console.ReadLine());
            double thickness = 0.4;

            if (r == 0)
            {
                Console.WriteLine(Program.errorMessage);
            }

            else
            {
                double rIn = r - thickness, rOut = r + thickness;

                for (double y = r; y >= -r; --y)
                {
                    for (double x = -r; x < rOut; x += 0.5)
                    {
                        double value = x * x + y * y;

                        if (value >= rIn * rIn && value <= rOut * rOut)
                        {
                            Console.Write('*');
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
