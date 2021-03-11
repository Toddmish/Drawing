using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    interface IRender
    {
        void RenderRectangle(uint x, uint y, uint width, uint height);
        void RenderSquare(uint x, uint y, uint size);
        void RenderCircle(uint x, uint y, uint diameter);
        void RenderEllipse(uint x, uint y, uint Hdiameter, uint Vdiameter);
        void RenderTextBox(uint x, uint y, uint width, uint height, string text);
    }
}
