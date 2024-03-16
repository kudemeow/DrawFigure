using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class AnotherTriangle : IFigure
    {
        private const string errorMessage = "You need to enter a positive number. Try again.";
        public void Draw()
        {
            Console.Write("Please enter height of the triangle: ");

            int height = Convert.ToInt32(Console.ReadLine());

            if (height == 0)
            {
                Console.WriteLine(errorMessage);
            }
            else
            {
                for (int i = 0; i < height; i++)
                {
                    Console.SetCursorPosition(height - i - 1, Console.CursorTop);
                    Console.WriteLine(new string('#', i * 2 + 1));
                }
            }
        }
    }
}
