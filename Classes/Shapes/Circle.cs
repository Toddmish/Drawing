
using System.Drawing;

namespace Drawings
{


    class Circle : Widget
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
        public Circle(uint _x, uint _y) : base(_x, _y)
        {

        }

        public override void Draw()
        {
            Render.RenderCircle(X, Y, size);
        }

    }
    
}
