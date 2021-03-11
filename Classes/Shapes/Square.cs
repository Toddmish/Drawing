using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class Square:Widget
    {
        private uint size = 0;
        public uint Size
        {
            get
            {
                return size;
            }

            set
            {
               size = value;
            }
        }
        public Square(uint _x,uint _y) : base(_x,_y)
        {
            
        }

        public override void Draw()
        {
            Render.RenderSquare(X, Y, size);
        }

    }
}
