using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8040_Ass1
{
    class Program
    {
        public static int ValidateMenu()
        {
            int ch = 0; //for switch
            while (true)
            {
                Console.WriteLine("\n1.Get Rectangle Length");
                Console.WriteLine("2.Change Rectangle Length");
                Console.WriteLine("3.Get Rectangle Width");
                Console.WriteLine("4.Change Rectangle Width");
                Console.WriteLine("5.Get Rectangle Perimeter");
                Console.WriteLine("6.Get Rectangle Area");
                Console.WriteLine("7.Exit");

                Console.Write("Enter your choice : ");
                var s = Console.ReadLine();
                if (!int.TryParse(s, out ch) || !((ch>0) && (ch<=7)))
                    Console.WriteLine("Invalid input!!!");
                else
                    break;
            }
            return ch;
        }
        public static int IntputValidate(string rSide)
        {
            int number = 1;
            while (true)
            {
                Console.Write("Enter " + rSide + " of rectangle(must be more than 0) : ");
                var s = Console.ReadLine();
                if (!int.TryParse(s, out number) || !(number > 0))
                    Console.WriteLine("Invalid input!!!");
                else
                    break;
            }
            return number; 
        }
        static void Main(string[] args)
        {
            int l = IntputValidate("length");
            int w = IntputValidate("width");

            Console.WriteLine("Your Rectangle is of "+l+" X "+w+".");
            Rectangle r = new Rectangle(l,w); // constructor calling

            while (true)
            {
                switch (Program.ValidateMenu())
                {
                    case 1:
                        Console.WriteLine("Length is " + r.GetLength() +".");
                        break;
                    case 2:
                        Console.WriteLine("New Length is "+r.SetLength(IntputValidate("length")) + ".");
                        break;
                    case 3:
                        Console.WriteLine("Width is " + r.GetWidth() + ".");
                        break;
                    case 4:
                        Console.WriteLine("New Width is " + r.SetWidth(IntputValidate("width")) + ".");
                        break;
                    case 5:
                        Console.WriteLine("Rectangle Perimeter is "+r.GetPerimeter() + ".");
                        break;
                    case 6:
                        Console.WriteLine("Rectangle Area is " + r.GetArea() + ".");
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
