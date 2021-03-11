﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drawings
{
    interface IDrawing
    {
        void Print();
        void Add(IWidget widget);
    }
}
