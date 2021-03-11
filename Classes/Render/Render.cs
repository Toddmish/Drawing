using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    /// <summary>
    /// That class is an implementation of IRender
    /// In this printer we choose to print by writting widget locations and their name to the 
    /// standard output stream.
    /// Another implementation of IRender could draw via DirectX,
    /// another one using WPF capabilities or 
    /// another one could call a HP Printer etc..
    /// </summary>
    class ConsRender :IRender
    {
        public ConsRender()
        {
                  
        }       

        public void RenderRectangle(uint x, uint y, uint width, uint height)
        {
            Console.WriteLine("Rectangle" + " ({0} {1}) Width = {2} Height ={3}", x, y , width , height);
        }
        public void RenderSquare(uint x, uint y, uint size)
        {
            Console.WriteLine("Rectangle" + " ({0} {1}) size = {2}", x, y, size);
        }
        public void RenderCircle(uint x, uint y, uint diameter)
        {
            Console.WriteLine("Rectangle" + " ({0} {1}) diameter = {2} ",x,y, diameter);
        }
        public void RenderEllipse(uint x, uint y, uint Hdiameter, uint Vdiameter)
        {
            Console.WriteLine("Rectangle" + " ({0} {1}) diameterH = {2} diameterV ={3}", x, y, Hdiameter,  Vdiameter);
        }
        public void RenderTextBox(uint x, uint y, uint width, uint height, string text)
        {
            Console.WriteLine("Rectangle" + " ({0} {1}) Height ={2} Text={3}", x, y, height,text);
        }

        /*
         * some older approach
        public void Print(IList<IWidget> widgets)
        {
            string output = String.Empty;

            foreach (IWidget widget in widgets)
            {
                output += widget.PrintOut() + System.Environment.NewLine;
            }
            /* thats is our printer
             uncomment the line
            //Console.WriteLine(output);
        }
        */
    }
}
