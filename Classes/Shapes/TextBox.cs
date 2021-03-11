using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class TextBox:Rectangle
    {
        private string text = String.Empty;
        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }
        public TextBox(uint _x, uint _y):base(_x,_y)
        {

        }

        public override void Draw()
        {
            Render.RenderTextBox(X, Y, Width, Height, "sample text");
        }

    }
}
