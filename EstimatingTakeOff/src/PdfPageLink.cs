using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.src
{
    public class PdfPageLink
    {
        public RectangleF Bounds { get; private set; } //location of the link
        public int? TargetPage { get; private set; } //the target of the link
        public string Uri { get;  private set; } //the target URI of the link

        //creates a new instance of the PdfPageLink class
        public PdfPageLink(RectangleF bounds, int? targetPage, string uri)
        {
            Bounds = bounds;
            TargetPage = targetPage;
            Uri = uri;
        }   
    }
}
