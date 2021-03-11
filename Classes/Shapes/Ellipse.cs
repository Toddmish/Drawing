using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class Ellipse:Widget
    { 
        private uint diameterX = 0;
        private uint diameterY = 0;
        public uint DiameterX
        {
            get
            {
                return diameterX;
            }

            set
            {
                diameterX = value;
            }
        }
        
        public uint DiameterY
        {
            get
            {
                return diameterY;
            }

            set
            {
                diameterY = value;
            }
        }

        public Ellipse(uint _x, uint _y) : base(_x, _y)
        {

        }

        public override void Draw()
        {
            Render.RenderEllipse(X, Y, diameterX,DiameterY);
        }
        /* some initial approach
        public override string PrintOut()
        {
            //to redo this
            return base.PrintOut() + " DiameterX=" + diameterX + " DiameterY=" + diameterY;
        }
        */

    }
}
