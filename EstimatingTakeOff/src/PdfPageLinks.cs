using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EstimatingTakeOff.src
{
    public class PdfPageLinks
    {
        public IList<PdfPageLink> Links { get; private set; }

        public PdfPageLinks(IList<PdfPageLink> links)
        {
            if (links == null)
                throw new ArgumentNullException(nameof(links));

            Links = new ReadOnlyCollection<PdfPageLink>(links);
        }
    }
}
