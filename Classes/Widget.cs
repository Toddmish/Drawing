

namespace Drawings
{

    class Widget:IWidget
    {
        private IRender render;
        private uint x = 0;
        private uint y = 0;
        public uint X
        {
            get
            {
                return x;
            }
            
            set
            {
                x = value;
            } 
        }

        public uint Y
        {
            get
            {
                return y;
            }

            set
            {
                y = value;
            }
        }

        public IRender Render
        {
            get
            {
                return render;
            }

            set
            {
                render = value;
            }
        }

        public Widget(uint _x,uint _y)
        {
            x = _x;
            y = _y;
        }

        public virtual void Draw()
        {
            
        }

        /*
        public virtual string PrintOut()
        {
            //to redo this
            string message = string.Format(this.GetType().Name + " ({0} {1}) ", x, y);
            return message;
        }
        */
    }
}
