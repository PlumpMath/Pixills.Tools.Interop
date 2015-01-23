using System;
using System.Net;
using System.Runtime.InteropServices;

namespace Pixills.Interop.Networking
{
	public struct IpForwardRow 
	{
		public IPAddress ForwardDestination;
		public IPAddress ForwardMask;
		public uint ForwardPolicy;
		public IPAddress ForwardNextHop;
		public uint ForwardIfIndex;
		public IPFORWARDTYPE ForwardType;
		public PROTOCOL ForwardProtocol;
		public uint ForwardAge;
		public uint ForwardNextHopAS;
		public uint ForwardMetric1;
		public uint ForwardMetric2;
		public uint ForwardMetric3;
		public uint ForwardMetric4;
		public uint ForwardMetric5;
	}
}
