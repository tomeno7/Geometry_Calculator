using Geometry_Calculator.Controllers;
using Geometry_Calculator.Models;
using Geometry_Calculator.Views;

class Program
{
    static void Main(string[] args)
    {
        ShapeView view = new ShapeView();
        ShapeController controller = new ShapeController();

        view.Show();
        string choice = Console.ReadLine();

        Shape shape = null;

        switch (choice)
        {
            case "1":
                Console.WriteLine("Podaj szerokość:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Podaj wysokość:");
                double height = Convert.ToDouble(Console.ReadLine());
                shape = new Rectangle(width, height);
                break;
            case "2":
                Console.WriteLine("Podaj promień:");
                double radius = Convert.ToDouble(Console.ReadLine());
                shape = new Circle(radius);
                break;
        }

        if (shape != null)
        {
            controller.DisplayShapeInfo(shape);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy wybór.");
        }
    }
}

