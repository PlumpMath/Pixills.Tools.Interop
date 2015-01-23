using Pixills.Interop.Types;
using System;
using System.Runtime.InteropServices;
using HANDLE = System.Runtime.InteropServices.HandleRef;

namespace Pixills.Interop.Networking
{
	internal class IPHLPAPI
    {
        [DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR GetIpForwardTable(
			[Out] IntPtr ipForwardTable,
			ref uint size, 
            bool order);

		[DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR GetIpAddrTable(
			[Out] IntPtr ipAddressTable,
			ref uint size,
			bool order);

		[DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR GetIpNetTable(
			 [Out] IntPtr ipNetTable,
			 ref uint size,
			 bool order);

		[DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR NotifyAddrChange(out HANDLE handle, OVERLAPPED overlapped);

		[DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR NotifyRouteChange(out HANDLE handle, OVERLAPPED overlapped);

		[DllImport("IPHLPAPI.DLL", SetLastError = true)]
		internal static extern ERROR CancelIPChangeNotify(OVERLAPPED notifyOverlapped);
    }
}
