using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    internal class Program
    {
        internal const string errorMessage = "You need to enter a positive number. Try again.";

        private static int Menu()
        {
            int item;

            string[] menu = new string[]
            {
                "1 - Circle",
                "2 - Triangle",
                "3 - Another triangle",
                "4 - Square",
                "5 - Rectangle",
                "0 - Exit"
            };

            Console.WriteLine(string.Join(Environment.NewLine, menu));

            Console.Write("Select a menu item and enter it: ");

            item = Convert.ToInt32(Console.ReadLine());

            if ((item >= 0) && (item <= 5))
            {
                return item;
            }
            else
                return 0;
        }

        static void Main(string[] args)
        {
            int item;
            IFigure figure = null;

            while ((item = Menu()) > 0)
            {
                switch (item)
                {
                    case 1:
                        figure = new Circle();
                        break;
                    case 2:
                        figure = new Triangle();
                        break;

                    case 3:
                        figure = new AnotherTriangle();
                        break;

                    case 4:
                        figure = new Square();
                        break;
                    case 5:
                        figure = new Rectangle();
                        break;
                }

                if (figure != null)
                    figure.Draw();
                else
                    Console.WriteLine("Object wasn't created");
            }

            Console.WriteLine(errorMessage);
        }
    }
}
