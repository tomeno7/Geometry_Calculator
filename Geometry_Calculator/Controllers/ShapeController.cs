using Geometry_Calculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry_Calculator.Controllers
{
    public class ShapeController
    {
        public void DisplayShapeInfo(Shape shape)
        {
            Console.WriteLine($"Area: {shape.CalculateArea()}");
            Console.WriteLine($"Perimeter: {shape.CalculatePerimeter()}");
        }
    }

}
