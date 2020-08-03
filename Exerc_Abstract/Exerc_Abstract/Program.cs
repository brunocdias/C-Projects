using Exerc_Abstract.Entities;
using Exerc_Abstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exerc_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Enum color = Enum.Parse<Color>(Console.ReadLine());
                if(shape == 'r')
                {
                    Console.Write("Width: ");
                    double widht = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shapes.Add(new Rectangle(color, widht, height ));
                }

            }
        }
    }
}
