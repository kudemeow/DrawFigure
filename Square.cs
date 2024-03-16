using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Square : IFigure
    {
        

        public void Draw()
        {
            Console.Write("Enter size of a square's side: ");
            int side = Convert.ToInt32(Console.ReadLine());

            if (side == 0 || side < 0)
            {
                Console.WriteLine(Program.errorMessage);
            }
            else
            {
                for (int i = 0; i < side; i++)
                {
                    for (int j = 0; j < side; j++)
                    {
                        if (i == 0 || j == 0 || i == side - 1 || j == side - 1)
                            Console.Write("#");
                        else
                            Console.Write(" ");
                    }

                    Console.WriteLine();
                }

            }
        }
    }
}
