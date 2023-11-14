using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleRectangleEditor.Models
{
    internal enum FigureActionMode
    {
        None,
        Drawing,
        Moving,
        ResizingTopLeft,
        ResizingTopRight,
        ResizingBottomLeft,
        ResizingBottomRight,
        ResizingTop,
        ResizingBottom,
        ResizingLeft,
        ResizingRight,
    }
}
