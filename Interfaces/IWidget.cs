
using System.Drawing;


namespace Drawings
{
    interface IWidget
    {
        void Draw();
        IRender Render
        {
            get;
            set;
        }
    }
}
