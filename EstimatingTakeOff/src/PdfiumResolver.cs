using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.src
{
    public class PdfiumResolver
    {
        public static event PdfiumResolveEventHandler Resolver;

        private static void OnResolve(PdfiumResolveEventArgs e)
        {
            Resolver?.Invoke(null, e);
        }

        internal static string GetPdfiumFileName()
        {
            var e = new PdfiumResolveEventArgs();
            OnResolve(e);
            return e.PdfiumFileName;
        }
    }
}
