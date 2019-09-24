using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigement1
{
    class Program
    {
        public static int ValidateSelection()
        {
            string givenInput = "";
            bool validMenu = false;
            while (validMenu == false)
            {
                Console.WriteLine("1 = get rectangle length");
                Console.WriteLine("2 = change rectangle length");
                Console.WriteLine("3 = get rectangle width");
                Console.WriteLine("4 = change rectangle width");
                Console.WriteLine("5 = get rectangle area");
                Console.WriteLine("6 = get rectangle perimeter");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("please select a option, by entering a number:\n");
                givenInput = Console.ReadLine();
                if(givenInput !="1" &&
                   givenInput !="2" &&
                   givenInput !="3" &&
                   givenInput !="4" &&
                   givenInput !="5" &&
                   givenInput !="6" &&
                   givenInput !="7")
                {
                    Console.WriteLine("its not a valid menu option,please try again:\n");
                }
                else
                {
                    validMenu = true;

                }
            }
            Console.WriteLine();
            return int.Parse(givenInput);
        }
        public static int ValidateInput(string GivenNumber)
        {
            int num = 1;
            bool isValid = false;

            while(isValid == false)
            {
                Console.WriteLine($"please enter {GivenNumber}:of rectangle");
                string givenInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(givenInput, out num);
                if (result == false)
                {
                    Console.WriteLine("its not a valid input please,try again.\n");
                }
                else if(num <0)
                {
                    Console.WriteLine("number cannot be less than zero,try again.\n");
                }
                else
                {
                    isValid = true;
                    Console.WriteLine($"number given is :{num}.\n");
                }
            }

            return num;

        }
        static void Main(string[] args)
        {
            RectangleClass c = new RectangleClass();
            bool ValidRectangleSelect = false;
            string RectangleSelection;
            int input;

            while(ValidRectangleSelect == false)
            {
                Console.WriteLine("1 = default rectangle of (2 unit X 2 unit)\n");
                Console.WriteLine("2 = choose your number\n");
                Console.WriteLine("choose a menu to begin:");
                RectangleSelection = Console.ReadLine();
                Console.WriteLine();
                if (RectangleSelection !="1" && RectangleSelection !="2")
                {
                    Console.WriteLine("its not a valid selection,please try again.\n");
                }

                else if(int.Parse(RectangleSelection) == 1)
                {
                    ValidRectangleSelect = true;
                    int Length = 2;
                    int Width = 2;
                    Console.WriteLine($"your default rectangle is {Length} X {Width}\n");

                }
                else if(int.Parse(RectangleSelection) == 2)
                {
                    ValidRectangleSelect = true;
                    int length;
                    int width;
                    length = ValidateInput("length");
                    width = ValidateInput("width");

                    Console.WriteLine($"your custom Rectangle is {length} and {width}.\n");
                    RectangleClass customRectangle = new RectangleClass(length, width);
                    c = customRectangle;
                }
            }
            input = ValidateSelection();
            while (input != 7)
            {
                int result;
                switch(input)
                {
                    case 1:
                        Console.WriteLine($"length is: {c.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateInput("length");
                        c.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"width is :{c.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateInput("width");
                        c.Setwidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"area of rectangle is:{c.Getarea()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"Perimeter of rectangle is :{c.Getperimeter()}\n");
                        break;

                    default:
                        break;
                }
                input = ValidateSelection();
            }
        }
    }
}
