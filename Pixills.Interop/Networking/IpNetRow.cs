using System;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;

namespace Pixills.Interop.Networking
{
	public class IpNetRow : Marshallable<IpNetRow>
	{
		public uint Index { get; set; }
		public uint AddrLen { get; set; }
		public byte[] PhysicalAddress { get; set; }
		public IPAddress Address { get; set; }
		public IPNETTYPE Type { get; set; }

		internal override int Size
		{
			get { return 4 + (int)AddrLen; }
		}

		internal override IpNetRow Read(IntPtr pData)
		{
			var index = Marshal.ReadInt32(pData);
			IntPtr.Add(pData, sizeof(int));
			var addrLen = Marshal.ReadInt32(pData);
			IntPtr.Add(pData, sizeof(int));
			var physicalAddress = new byte[addrLen];

			for (var i = 0; i < AddrLen; i++ )
			{
				physicalAddress[i] = Marshal.ReadByte(pData, i);
				IntPtr.Add(pData, 1);
			}

			var address = (IPAddress)Marshal.PtrToStructure(pData, typeof(IPAddress));
			IntPtr.Add(pData, sizeof(int));
			var type = (IPNETTYPE)Marshal.ReadInt32(pData);

			return new IpNetRow
			{
				Index = (uint)index,
				AddrLen = (uint)addrLen,
				PhysicalAddress = physicalAddress,
				Address = address,
				Type = type
			};
		}

		internal override IntPtr Write(IpNetRow obj)
		{
			var ptr = Marshal.AllocHGlobal(obj.Size);
			return ptr;
		}

		public override string ToString()
		{
			return string.Format("{1}\t\t\t{2}\t\t\t{3}{0}", Address, ASCIIEncoding.ASCII.GetString(PhysicalAddress), Type, Environment.NewLine);
		}
	}
}
