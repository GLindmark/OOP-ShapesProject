using System;

namespace OOPS_ShapesProject {
    class Program {
        static void Main(string[] args) {

            var quad1 = new Quad( 5, 7, 13, 6);
            //quad1.side1 = 5;
            //quad1.side2 = 7;
            //quad1.side3 = 13;
            //quad1.side4 = 6;

            var perimeter = quad1.GetPerimeter();//must start with the instance "quad1", then the .Get....
            var area1 = quad1.GetArea();
            Console.WriteLine($"The quad perimeter is {perimeter}");

            var rect1 = new Rect(5, 13);

            perimeter = rect1.GetPerimeter();
            var area = rect1.GetArea();
            Console.WriteLine($"The rect perimeter is {perimeter} the area is {area}");

            var square1 = new Square(5);

            perimeter = square1.GetPerimeter();
            Console.WriteLine($"The square perimeter is {perimeter}");



           // var area = rect1.GetArea();
            Console.WriteLine($"The area of the Rectangle is {area}");

            area = square1.GetArea();
            Console.WriteLine($"The area of the Square is {area}");


        }
    }
}
