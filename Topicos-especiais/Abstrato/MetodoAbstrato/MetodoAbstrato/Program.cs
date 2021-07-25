using System;
using System.Collections.Generic;
using MetodoAbstrato.Entities;
using MetodoAbstrato.Entities.Enums;

namespace MetodoAbstrato {
    class Program {
        static void Main(string[] args) {

            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number of shapes: ");
            int shapes = int.Parse(Console.ReadLine());

            for(int i = 1; i <= shapes; i++) {
                Console.WriteLine($"Shape #{i} data: ");
                Console.WriteLine("Rectangle or Circle (r/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if(ch == 'r') {
                    Console.WriteLine("Width: ");
                    double witdh = double.Parse(Console.ReadLine());
                    Console.WriteLine("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    list.Add(new Rectangle(witdh, height, color));

                }
                else {
                    Console.WriteLine("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    list.Add(new Circle(radius, color));
                }
            }
            Console.WriteLine("\n SHAPES AREAS: ");
            foreach (Shape shape in list) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }
        }
    }
}
