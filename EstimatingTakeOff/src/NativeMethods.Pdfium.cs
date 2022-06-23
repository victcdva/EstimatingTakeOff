using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EstimatingTakeOff.src
{
    partial class NativeMethods
    {
        private static class Imports
        {
            [DllImport("pdfium.dll")]
            public static extern void FPDF_AddRef();

            [DllImport("pdfium.dll")]
            public static extern void FPDF_Release();

            [DllImport("pdfium.dll", CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadCustomDocument([MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEACCESS access, string password);

            [DllImport("pdfium.dll", CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadMemDocument(SafeHandle data_buf, int size, string password);

            [DllImport("pdfium.dll", CharSet = CharSet.Ansi)]
            public static extern IntPtr FPDF_LoadMemDocument(byte[] data_buf, int size, string password);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_CloseDocument(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern int FPDF_GetPageCount(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern uint FPDF_GetDocPermissions(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFDOC_InitFormFillEnvironment(IntPtr document, FPDF_FORMFILLINFO formInfo);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_SetFormFieldHighlightColor(IntPtr hHandle, int fieldType, uint color);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_SetFormFieldHighlightAlpha(IntPtr hHandle, byte alpha);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentJSAction(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentOpenAction(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FPDFDOC_ExitFormFillEnvironment(IntPtr hHandle);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoDocumentAAction(IntPtr hHandle, FPDFDOC_AACTION aaType);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDF_LoadPage(IntPtr document, int page_index);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFText_LoadPage(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FORM_OnAfterLoadPage(IntPtr page, IntPtr _form);

            [DllImport("pdfium.dll")]
            public static extern void FORM_DoPageAAction(IntPtr page, IntPtr _form, FPDFPAGE_AACTION fPDFPAGE_AACTION);

            [DllImport("pdfium.dll")]
            public static extern double FPDF_GetPageWidth(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern double FPDF_GetPageHeight(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FORM_OnBeforeClosePage(IntPtr page, IntPtr _form);

            [DllImport("pdfium.dll")]
            public static extern void FPDFText_ClosePage(IntPtr text_page);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_ClosePage(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_RenderPage(IntPtr dc, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_RenderPageBitmap(IntPtr bitmapHandle, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);

            [DllImport("pdfium.dll")]
            public static extern int FPDF_GetPageSizeByIndex(IntPtr document, int page_index, out double width, out double height);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBitmap_CreateEx(int width, int height, int format, IntPtr first_scan, int stride);

            [DllImport("pdfium.dll")]
            public static extern void FPDFBitmap_FillRect(IntPtr bitmapHandle, int left, int top, int width, int height, uint color);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBitmap_Destroy(IntPtr bitmapHandle);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFText_FindStart(IntPtr page, byte[] findWhat, FPDF_SEARCH_FLAGS flags, int start_index);

            [DllImport("pdfium.dll")]
            public static extern int FPDFText_GetSchResultIndex(IntPtr handle);

            [DllImport("pdfium.dll")]
            public static extern int FPDFText_GetSchCount(IntPtr handle);

            [DllImport("pdfium.dll")]
            public static extern int FPDFText_GetText(IntPtr page, int start_index, int count, byte[] result);

            [DllImport("pdfium.dll")]
            public static extern void FPDFText_GetCharBox(IntPtr page, int index, out double left, out double right, out double bottom, out double top);

            [DllImport("pdfium.dll")]
            public static extern int FPDFText_CountChars(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern bool FPDFText_FindNext(IntPtr handle);

            [DllImport("pdfium.dll")]
            public static extern void FPDFText_FindClose(IntPtr handle);

            [DllImport("pdfium.dll")]
            public static extern bool FPDFLink_Enumerate(IntPtr page, ref int startPos, out IntPtr linkAnnot);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFLink_GetDest(IntPtr document, IntPtr link);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFDest_GetPageIndex(IntPtr document, IntPtr dest);

            [DllImport("pdfium.dll")]
            public static extern bool FPDFLink_GetAnnotRect(IntPtr linkAnnot, FS_RECTF rect);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_DeviceToPage(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, int device_x, int device_y, out double page_x, out double page_y);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_PageToDevice(IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, double page_x, double page_y, out int device_x, out int device_y);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFLink_GetAction(IntPtr link);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFAction_GetURIPath(IntPtr document, IntPtr action, StringBuilder buffer, uint buflen);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetFirstChild(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetNextSibling(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFBookmark_GetTitle(IntPtr bookmark, byte[] buffer, uint buflen);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetAction(IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFBookmark_GetDest(IntPtr document, IntPtr bookmark);

            [DllImport("pdfium.dll")]
            public static extern uint FPDFAction_GetType(IntPtr action);

            [DllImport("pdfium.dll")]
            public static extern uint FPDF_GetLastError();

            [DllImport("pdfium.dll")]
            public static extern uint FPDF_GetMetaText(IntPtr document, string tag, byte[] buffer, uint buflen);

            [DllImport("pdfium.dll")]
            public static extern bool FPDF_ImportPages(IntPtr destDoc, IntPtr srcDoc, [MarshalAs(UnmanagedType.LPStr)] string pageRange, int index);

            [DllImport("pdfium.dll")]
            public static extern bool FPDF_SaveAsCopy(IntPtr doc,
                [MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEWRITE writer,
                [MarshalAs(UnmanagedType.I4)] FPDF_SAVE_FLAGS flag);

            [DllImport("pdfium.dll")]
            public static extern bool FPDF_SaveWithVersion(IntPtr doc,
                [MarshalAs(UnmanagedType.LPStruct)] FPDF_FILEWRITE writer,
                [MarshalAs(UnmanagedType.I4)] FPDF_SAVE_FLAGS flags,
                int fileVersion);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFPage_New(IntPtr doc, int index, double width, double height);

            [DllImport("pdfium.dll")]
            public static extern void FPDFPage_Delete(IntPtr doc, int index);

            [DllImport("pdfium.dll")]
            public static extern int FPDFPage_GetRotation(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FPDFPage_SetRotation(IntPtr page, int rotate);

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDF_CreateNewDocument();

            [DllImport("pdfium.dll")]
            public static extern IntPtr FPDFPageObj_NewImgeObj(IntPtr document);

            [DllImport("pdfium.dll")]
            public static extern bool FPDFImageObj_SetBitmap(IntPtr pages, int count, IntPtr imageObject, IntPtr bitmap);

            [DllImport("pdfium.dll")]
            public static extern void FPDFPageObj_Transform(IntPtr page, double a, double b, double c, double d, double e, double f);

            [DllImport("pdfium.dll")]
            public static extern void FPDFPage_InsertObject(IntPtr page, IntPtr pageObject);

            [DllImport("pdfium.dll")]
            public static extern bool FPDFPage_GenerateContent(IntPtr page);

            [DllImport("pdfium.dll")]
            public static extern void FPDF_FFLDraw(IntPtr form, IntPtr bitmap, IntPtr page, int start_x, int start_y, int size_x, int size_y, int rotate, FPDF flags);
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FORMFILLINFO
        {
            public int version;
            private readonly IntPtr Release;
            private readonly IntPtr FFI_Invalidate;
            private readonly IntPtr FFI_OutputSelectedRect;
            private readonly IntPtr FFI_SetCursor;
            private readonly IntPtr FFI_SetTimer;
            private readonly IntPtr FFI_KillTimer;
            private readonly IntPtr FFI_GetLocalTime;
            private readonly IntPtr FFI_OnChange;
            private readonly IntPtr FFI_GetPage;
            private readonly IntPtr FFI_GetCurrentPage;
            private readonly IntPtr FFI_GetRotation;
            private readonly IntPtr FFI_ExecuteNamedAction;
            private readonly IntPtr FFI_SetTextFieldFocus;
            private readonly IntPtr FFI_DoURIAction;
            private readonly IntPtr FFI_DoGoToAction;
            private readonly IntPtr m_pJsPlatform;

            // XFA support i.e. version 2

            private readonly IntPtr FFI_DisplayCaret;
            private readonly IntPtr FFI_GetCurrentPageIndex;
            private readonly IntPtr FFI_SetCurrentPage;
            private readonly IntPtr FFI_GotoURL;
            private readonly IntPtr FFI_GetPageViewRect;
            private readonly IntPtr FFI_PageEvent;
            private readonly IntPtr FFI_PopupMenu;
            private readonly IntPtr FFI_OpenFile;
            private readonly IntPtr FFI_EmailTo;
            private readonly IntPtr FFI_UploadTo;
            private readonly IntPtr FFI_GetPlatform;
            private readonly IntPtr FFI_GetLanguage;
            private readonly IntPtr FFI_DownloadFromURL;
            private readonly IntPtr FFI_PostRequestURL;
            private readonly IntPtr FFI_PutRequestURL;
        }

        public enum FPDF_UNSP
        {
            DOC_XFAFORM = 1,
            DOC_PORTABLECOLLECTION = 2,
            DOC_ATTACHMENT = 3,
            DOC_SECURITY = 4,
            DOC_SHAREDREVIEW = 5,
            DOC_SHAREDFORM_ACROBAT = 6,
            DOC_SHAREDFORM_FILESYSTEM = 7,
            DOC_SHAREDFORM_EMAIL = 8,
            ANNOT_3DANNOT = 11,
            ANNOT_MOVIE = 12,
            ANNOT_SOUND = 13,
            ANNOT_SCREEN_MEDIA = 14,
            ANNOT_SCREEN_RICHMEDIA = 15,
            ANNOT_ATTACHMENT = 16,
            ANNOT_SIG = 17
        }

        public enum FPDFDOC_AACTION
        {
            WC = 0x10,
            WS = 0x11,
            DS = 0x12,
            WP = 0x13,
            DP = 0x14
        }

        public enum FPDFPAGE_AACTION
        {
            OPEN = 0,
            CLOSE = 1
        }

        [Flags]
        public enum FPDF
        {
            ANNOT = 0x01,
            LCD_TEXT = 0x02,
            NO_NATIVETEXT = 0x04,
            GRAYSCALE = 0x08,
            DEBUG_INFO = 0x80,
            NO_CATCH = 0x100,
            RENDER_LIMITEDIMAGECACHE = 0x200,
            RENDER_FORCEHALFTONE = 0x400,
            PRINTING = 0x800,
            REVERSE_BYTE_ORDER = 0x10
        }

        [Flags]
        public enum FPDF_SEARCH_FLAGS
        {
            FPDF_MATCHCASE = 1,
            FPDF_MATCHWHOLEWORD = 2
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FS_RECTF
        {
            public float left;
            public float top;
            public float right;
            public float bottom;
        }

        public enum FPDF_ERR : uint
        {
            FPDF_ERR_SUCCESS = 0,		// No error.
            FPDF_ERR_UNKNOWN = 1,		// Unknown error.
            FPDF_ERR_FILE = 2,		// File not found or could not be opened.
            FPDF_ERR_FORMAT = 3,		// File not in PDF format or corrupted.
            FPDF_ERR_PASSWORD = 4,		// Password required or incorrect password.
            FPDF_ERR_SECURITY = 5,		// Unsupported security scheme.
            FPDF_ERR_PAGE = 6		// Page not found or content error.
        }

        [Flags]
        public enum FPDF_SAVE_FLAGS
        {
            FPDF_INCREMENTAL = 1,
            FPDF_NO_INCREMENTAL = 2,
            FPDF_REMOVE_SECURITY = 3
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEACCESS
        {
            public uint m_FileLen;
            public IntPtr m_GetBlock;
            public IntPtr m_Param;
        }

        [StructLayout(LayoutKind.Sequential)]
        public class FPDF_FILEWRITE
        {
            public int version;
            public IntPtr WriteBlock;
            public IntPtr stream;
        }
    }
}
