﻿using EstimatingTakeOff.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.Enums
{
    public enum PdfError
    {
        Success = (int)NativeMethods.FPDF_ERR.FPDF_ERR_SUCCESS,
        Unknown = (int)NativeMethods.FPDF_ERR.FPDF_ERR_UNKNOWN,
        CannotOpenFile = (int)NativeMethods.FPDF_ERR.FPDF_ERR_FILE,
        InvalidFormat = (int)NativeMethods.FPDF_ERR.FPDF_ERR_FORMAT,
        PasswordProtected = (int)NativeMethods.FPDF_ERR.FPDF_ERR_PASSWORD,
        UnsupportedSecurityScheme = (int)NativeMethods.FPDF_ERR.FPDF_ERR_SECURITY,
        PageNotFound = (int)NativeMethods.FPDF_ERR.FPDF_ERR_PAGE
    }
}
