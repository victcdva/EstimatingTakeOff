using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.Enums
{
    /// <summary>
    /// Specifies the rotation of pages shown in the PDF renderer.
    /// Rotate0: Rotates the output 0 degrees.
    /// Rotate90: Rotates the output 90 degrees.
    /// Rotate180: Rotates the output 180 degrees.
    /// Rotate270: Rotates the output 270 degrees.
    /// </summary>
    public enum PdfRotation
    {
        Rotate0,
        Rotate90,
        Rotate180,
        Rotate270
    }
}
