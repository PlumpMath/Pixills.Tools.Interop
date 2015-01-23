using System.Net;
using System.Runtime.InteropServices;

namespace Pixills.Interop.Networking
{
	public struct IpAddressRow
	{
		public IPAddress Address;
		public uint Index;
		public IPAddress Mask;
		public IPAddress BroadcastAddress;
		public uint ReasmSize;
		public ushort Type;
	}
}
