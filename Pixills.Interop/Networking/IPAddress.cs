using System.Net;

namespace Pixills.Interop.Networking
{
	public struct IPAddress
	{
		public byte B1 { get; set; }
		public byte B2 { get; set; }
		public byte B3 { get; set; }
		public byte B4 { get; set; }

		public System.Net.IPAddress AsIPAddress()
		{
			return new System.Net.IPAddress(new[] { B1, B2, B3, B4 });
		}

		public override string ToString()
		{
			return AsIPAddress().ToString();
		}
	}
}
