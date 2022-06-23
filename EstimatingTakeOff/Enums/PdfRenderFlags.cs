using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.Enums
{
    /// <summary>
    /// Flags that influence the page rendering process.
    /// </summary>
    [Flags]
    public enum PdfRenderFlags
    {
        None = 0,
        Transparent = 0x1000,
        CorrectFromDpi = 0x2000
    }
}
