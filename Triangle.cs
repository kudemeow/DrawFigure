using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Triangle : IFigure
    {
        public void Draw()
        {
            Console.Write("Enter height of a triangle: ");

            int height = Convert.ToInt32(Console.ReadLine());

            if (height == 0)
            {
                Console.WriteLine(Program.errorMessage);
            }
            else
            {
                for (int i = 0; i <= height; i++)
                {
                    Console.WriteLine(new string('#', i));
                }
            }
        }
    }
}
