using System.Linq;
using System.Collections.Generic;
using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Pixills.Interop.Networking
{
	public class IpForwardTable : Marshallable<IpForwardTable>
	{
		public IEnumerable<IpForwardRow> Table { get; set; }

		internal override IpForwardTable Read(IntPtr pData)
		{
			var size = Marshal.ReadInt32(pData);
			var list = new List<IpForwardRow>();
			var startAdress = (int)pData + sizeof(int);
			for (var i = 0; i < size; i++)
			{
				var rowPtr = (IntPtr)(startAdress + i * Marshal.SizeOf(typeof(IpForwardRow)));
				var row = (IpForwardRow)Marshal.PtrToStructure(rowPtr, typeof(IpForwardRow));
				list.Add(row);
			}
			return new IpForwardTable { Table = list };
		}

		internal override IntPtr Write(IpForwardTable obj)
		{
			var ptr = Marshal.AllocHGlobal(obj.Size);
			var wPtr = ptr;
			Marshal.WriteInt32(wPtr, obj.Table.Count());
			IntPtr.Add(wPtr, sizeof(int));
			foreach(var row in obj.Table)
			{
				Marshal.StructureToPtr(obj, wPtr, false);
				IntPtr.Add(wPtr, Marshal.SizeOf(typeof(IpForwardRow)));
			}
			return ptr;
		}

		internal override int Size
		{
			get
			{
				return Marshal.SizeOf(typeof(IpForwardRow)) * Table.Count() + sizeof(int);
			}
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("DST\t\t\tNXT HP\t\t\tMASK{0}", Environment.NewLine);
			foreach(var row in Table)
			{
				sb.AppendFormat("{1}\t\t\t{2}\t\t\t{3}{0}", Environment.NewLine, row.ForwardDestination, row.ForwardNextHop, row.ForwardMask);
			}
			return sb.ToString();
		}
	}
}
