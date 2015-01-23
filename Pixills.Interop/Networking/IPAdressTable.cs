using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pixills.Interop.Networking
{
	public class IPAdressTable : Marshallable<IPAdressTable>
	{
		public IEnumerable<IpAddressRow> Table { get; set; }

		internal override int Size
		{
			get
			{
				return Marshal.SizeOf(typeof(IpAddressRow)) * Table.Count() + sizeof(int);
			}
		}

		internal override IPAdressTable Read(IntPtr pData)
		{
			var size = Marshal.ReadInt32(pData);
			var list = new List<IpAddressRow>();
			var startAdress = (int)pData + sizeof(int);
			for (var i = 0; i < size; i++)
			{
				var rowPtr = (IntPtr)(startAdress + i * Marshal.SizeOf(typeof(IpAddressRow)));
				var row = (IpAddressRow)Marshal.PtrToStructure(rowPtr, typeof(IpAddressRow));
				list.Add(row);
			}
			return new IPAdressTable{ Table = list };
		}

		internal override IntPtr Write(IPAdressTable obj)
		{
			var ptr = Marshal.AllocHGlobal(obj.Size);
			var wPtr = ptr;
			Marshal.WriteInt32(wPtr, obj.Table.Count());
			IntPtr.Add(wPtr, sizeof(int));
			foreach (var row in obj.Table)
			{
				Marshal.StructureToPtr(obj, wPtr, false);
				IntPtr.Add(wPtr, Marshal.SizeOf(typeof(IpForwardRow)));
			}
			return ptr;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("ADR\t\t\tBCAST ADR\t\t\tMASK{0}", Environment.NewLine);
			foreach (var row in Table)
			{
				sb.AppendFormat("{1}\t\t\t{2}\t\t\t{3}{0}", Environment.NewLine, row.Address, row.BroadcastAddress, row.Mask);
			}
			return sb.ToString();
		}
	}
}
