using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.src
{
    public class PdfiumResolveEventArgs : EventArgs
    {
        public string PdfiumFileName { get; set; }
    }

    public delegate void PdfiumResolveEventHandler(object sender, PdfiumResolveEventArgs e);
}
