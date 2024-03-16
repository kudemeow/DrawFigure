using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Rectangle : IFigure
    {
        public void Draw()
        {
            Console.Write("Enter height of a rectangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Enter a width of the rectangle: ");
            int width = Convert.ToInt32(Console.ReadLine());

            if((width == 0 || height == 0) || (width < 0 || height < 0))
            {
                Console.WriteLine(Program.errorMessage);
            }
            else
            {
                int area = height * width;

                for (int j = 0; j < width; j++)
                {
                    for (int i = 0; i < area; i++)
                    {
                        if (j == 0 || j == width - 1)
                            Console.Write("#");

                        else if (i == 0 || i == area - 1)
                            Console.Write("#");

                        else Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
