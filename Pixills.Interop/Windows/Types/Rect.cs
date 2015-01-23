using System.Runtime.InteropServices;

namespace Pixills.Tools.Interop.Windows.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int left, top, right, bottom;
    }
}
