using Pixills.Interop.Types;
using System;
using System.Runtime.InteropServices;

namespace Pixills.Interop.Networking
{
	public class Ip
	{
		// Address Table
		public static IPAdressTable GetAddressTable()
		{
			var pData = IntPtr.Zero;
			uint size = 0;
			var result = ERROR.ERROR_SUCCESS;

			if (IPHLPAPI.GetIpAddrTable(pData, ref size, false) == ERROR.ERROR_INSUFFICIENT_BUFFER)
			{
				pData = Marshal.AllocHGlobal((int)size);
				result = IPHLPAPI.GetIpAddrTable(pData, ref size, false);
				if (result != ERROR.ERROR_SUCCESS)
					return null;
			}

			return new IPAdressTable().Read(pData);
		}

		public static IPAdressTable GetAddressTable2()
		{
			return null;
		}

		public static void CreateAddressTableEntry(IpForwardRow row)
		{

		}

		public static void CreateAddressTableEntry2(IpForwardRow row)
		{

		}

		public static void DeleteAddressTableEntry(IpForwardRow row)
		{

		}

		public static void DeleteAddressTableEntry2(IpForwardRow row)
		{

		}

		// Forward Table
		public static IpForwardTable GetForwardTable()
		{
			var pData = IntPtr.Zero;
			uint size = 0;
			var result = ERROR.ERROR_SUCCESS;

			if (IPHLPAPI.GetIpForwardTable(pData, ref size, false) == ERROR.ERROR_INSUFFICIENT_BUFFER)
			{
				pData = Marshal.AllocHGlobal((int)size);
				result = IPHLPAPI.GetIpForwardTable(pData, ref size, false);
				if (result != ERROR.ERROR_SUCCESS)
					return null;
			}

			return new IpForwardTable().Read(pData);
		}

		public static IpForwardTable GetForwardTable2()
		{
			return null;
		}

		public static void CreateForwardTableEntry(IpForwardRow row)
		{

		}

		public static void CreateForwardTableEntry2(IpForwardRow row)
		{

		}

		public static void DeleteForwardTableEntry(IpForwardRow row)
		{

		}

		public static void DeleteForwardTableEntry2(IpForwardRow row)
		{

		}

		// Net Table
		public static IpNetTable GetNetTable()
		{
			var pData = IntPtr.Zero;
			uint size = 0;
			var result = ERROR.ERROR_SUCCESS;

			if (IPHLPAPI.GetIpNetTable(pData, ref size, false) == ERROR.ERROR_INSUFFICIENT_BUFFER)
			{
				pData = Marshal.AllocHGlobal((int)size);
				result = IPHLPAPI.GetIpNetTable(pData, ref size, false);
				if (result != ERROR.ERROR_SUCCESS)
					return null;
			}

			return new IpNetTable().Read(pData);
		}

		public static IpForwardTable GetNetTable2()
		{
			return null;
		}

		public static void CreateNetTableEntry(IpForwardRow row)
		{

		}

		public static void CreateNetTableEntry2(IpForwardRow row)
		{

		}

		public static void DeleteNetTableEntry(IpForwardRow row)
		{

		}

		public static void DeleteNetTableEntry2(IpForwardRow row)
		{

		}
	}
}
