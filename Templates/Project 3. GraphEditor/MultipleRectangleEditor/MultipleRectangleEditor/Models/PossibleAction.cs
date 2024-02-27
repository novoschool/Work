using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleRectangleEditor.Models
{
    internal enum PossibleAction
    {
        None,
        Select,
        Draw,
        Move,
        ResizeTopLeft,
        ResizeTopRight,
        ResizeBottomLeft,
        ResizeBottomRight,
        ResizeTop,
        ResizeBottom,
        ResizeLeft,
        ResizeRight,
    }
}
