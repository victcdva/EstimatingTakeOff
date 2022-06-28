﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.src
{
    internal class PdfLibrary : IDisposable
    {
        private static readonly object _syncRoot = new object();
        private static PdfLibrary _library;

        public static void EnsureLoaded()
        {
            lock (_syncRoot)
            {
                if(_library == null)
                    _library = new PdfLibrary();               
            }
        }
        
        private bool _disposed;

        private PdfLibrary()
        {
            NativeMethods.FPDF_AddRef();
        }

        ~PdfLibrary()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if(!disposing)
            {
                NativeMethods.FPDF_Release();
                _disposed = true;
            }
        }
    }
}
