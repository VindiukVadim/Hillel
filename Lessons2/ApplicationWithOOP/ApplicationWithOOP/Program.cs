using ApplicationWithOOP.Models;
using System.Collections;
using System.Drawing;

namespace ApplicationWithOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selectFigure;
            Console.WriteLine("Select type of figure you need create:");
            Console.WriteLine("1 - Rectangle");
            Console.WriteLine("2 - Circle");
            selectFigure = Console.ReadLine();

            switch (selectFigure)
            {
                case "1":
                    Console.WriteLine("Add Name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Add height:");
                    double height = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Add width:");
                    double width = Convert.ToDouble(Console.ReadLine());
                    RectangleUser rectangle = new RectangleUser(name, width, height);
                    Console.WriteLine("You created figure:");
                    Console.WriteLine(rectangle.Name + " " + rectangle.Width + " " + rectangle.Height);
                    Console.WriteLine("What we do with this figure");
                    Console.WriteLine("1 - Get area");
                    Console.WriteLine("2 - Get perimeter");
                    Console.WriteLine("3 - Resize");
                    string selectDo = Console.ReadLine();
                    switch (selectDo)
                    {
                        case "1":
                            double result = rectangle.GetArea();
                            Console.WriteLine("Area figure " + rectangle.Name + " = " + result);
                            break;
                        case "2":
                            result = rectangle.GetPerimeter();
                            Console.WriteLine("Perimeter figure " + rectangle.Name + " = " + result);
                            break;
                        case "3":
                            Console.WriteLine("New height:");
                            height = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("New width:");
                            width = Convert.ToDouble(Console.ReadLine());
                            rectangle.Resize(width, height);
                            Console.WriteLine("You are resize figure. New parametr is: "+rectangle.Height+" "+rectangle.Width);
                            break;
                    }

                    break;
                case "2":
                    Console.WriteLine("Add Name:");
                    name = Console.ReadLine();
                    Console.WriteLine("Add radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(name, radius);
                    Console.WriteLine("You created figure:");
                    Console.WriteLine(circle.Name + " " + circle.Radius);
                    Console.WriteLine("What we do with this figure");
                    Console.WriteLine("1 - Get area");
                    Console.WriteLine("2 - Get perimeter");
                    selectDo = Console.ReadLine();
                    switch (selectDo)
                    {
                        case "1":
                            double result = circle.GetArea();
                            Console.WriteLine("Area figure " + circle.Name + " = " + result);
                            break;
                        case "2":
                            result = circle.GetPerimeter();
                            Console.WriteLine("Perimeter figure " + circle.Name + " = " + result);
                            break;
                    }
                    break;


            }

        }
    }
}