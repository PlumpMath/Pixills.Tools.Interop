namespace Pixills.Tools.Interop.Windows.Types
{
    public enum WINDOW_STYLE : long
    {
        WS_BORDER           = 00800000,
        WS_CAPTION          = 0x00C00000,
        WS_CHILD            = 0x40000000,
        WS_CHILDWINDOW      = 0x40000000,
        WS_CLIPCHILDREN     = 0x02000000,
        WS_CLIPSIBLINGS     = 0x04000000,
        WS_DISABLED         = 0x08000000,
        WS_DLGFRAME         = 0x00400000,
        WS_GROUP            = 0x00020000,
        WS_HSCROLL          = 0x00100000,
        WS_ICONIC           = 0x20000000,
        WS_MAXIMIZE         = 0x01000000,
        WS_MAXIMIZEBOX      = 0x00010000,
        WS_MINIMIZE         = 0x20000000,
        WS_MINIMIZEBOX      = 0x00020000,
        WS_OVERLAPPED       = 0x00000000,
        //WS_OVERLAPPEDWINDOW = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
        //WS_POPUP            = 0x80000000,
        //WS_POPUPWINDOW      = (WS_POPUP | WS_BORDER | WS_SYSMENU),
        WS_SIZEBOX          = 0x00040000,
        WS_SYSMENU          = 0x00080000,
        WS_TABSTOP          = 0x00010000,
        WS_THICKFRAME       = 0x00040000,
        WS_TILED            = 0x00000000,
        //WS_TILEDWINDOW      = (WS_OVERLAPPED | WS_CAPTION | WS_SYSMENU | WS_THICKFRAME | WS_MINIMIZEBOX | WS_MAXIMIZEBOX),
        WS_VISIBLE          = 0x10000000,
        WS_VSCROLL          = 0x00200000,

        UNDOCUMENTED1       = 0x0000C03B,
        UNDOCUMENTED2       = 0x0000C0B4,

        UNDOCUMENTED3       = 0x0000C302,
        UNDOCUMENTED4       = 0x0000C33A,
        UNDOCUMENTED5       = 0x0000C33A,
        UNDOCUMENTED6       = 0x0000C380,

        UNDOCUMENTED7       = 0x0000C275,
        UNDOCUMENTED8       = 0x0000C27F,
        UNDOCUMENTED9       = 0x0000C2F1,
        UNDOCUMENTED10      = 0x0000C258,
        UNDOCUMENTED11      = 0x04C00000,
        UNDOCUMENTED12      = 0x17CF0000 // TASKBAR?
    }
}
