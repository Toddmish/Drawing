using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This program follows SOLID principles.
/// </summary>
namespace Drawings
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var widgets = new List<IWidget>()
            {
                 new Square(2, 2) { Size = 20 },
                 new Circle(1,3) { Size = 10 },
                 new Ellipse(4, 5) { DiameterX = 8, DiameterY=12 },
                 new Rectangle (1,3) { Width = 7, Height = 9},
                 new TextBox (1,3) { Width = 7, Height = 9, Text="Sample"}
            };

            foreach(IWidget widget in widgets)
            {
                Console.WriteLine(widget.PrintOut());
            }
           */


            IRender consolePrinter = new ConsRender();
            Drawing drawing = new Drawing(consolePrinter);
            drawing.Add(new Square(2, 2) { Size = 20 });
            drawing.Add(new Circle(1, 3) { Size = 10 });
            drawing.Add(new Ellipse(4, 5) { DiameterX = 8, DiameterY = 12 });
            drawing.Add(new Rectangle(1, 3) { Width = 7, Height = 9 });
            drawing.Add(new TextBox(1, 3) { Width = 7, Height = 9, Text = "SampleRec" });

            drawing.Print();

            Console.ReadLine();

        }
    }
}
