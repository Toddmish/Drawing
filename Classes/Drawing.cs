using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    class Drawing:IDrawing
    {
        /// <summary>
        /// Here we do not know about render implementation, we will get render object from 
        /// outside.
        /// This is done 
        /// </summary>
        private IRender render;

        private List<IWidget> widgets;

        public List<IWidget> Widgets
        {
            get
            {
                return widgets;
            }
            set
            {
                widgets = value;
            }
        }

        public Drawing(IRender _render)
        {
            widgets = new List<IWidget>();
            render = _render;
        }

        public void Add(IWidget widget)
        {
            widget.Render = render;
            widgets.Add(widget);
        }

        
        public void Print()
        {
        
            foreach (IWidget widget in widgets)
            {
                widget.Draw();// + System.Environment.NewLine;
            }
       
        }
       
      
    }
}
