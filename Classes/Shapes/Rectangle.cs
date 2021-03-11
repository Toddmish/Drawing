using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class Rectangle : Widget
    {
        private uint width = 0;
        private uint height = 0;
        public uint Width
        {
            get
            {
                return width;
            }

            set
            {
                width = value;
            }
        }

        public uint Height
        {
            get
            {
                return height;
            }

            set
            {
                height = value;
            }
        }

        public Rectangle(uint _x, uint _y) : base(_x, _y)
        {

        }

        public override void Draw()
        {
            Render.RenderRectangle(X,Y,Width,Height);
        }
    }
}
