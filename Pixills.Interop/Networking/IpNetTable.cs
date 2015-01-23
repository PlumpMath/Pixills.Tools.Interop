using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Pixills.Interop.Networking
{
	public class IpNetTable : Marshallable<IpNetTable>
	{
		public IEnumerable<IpNetRow> Table { get; set; }

		internal override int Size
		{
			get
			{
				return Marshal.SizeOf(typeof(IpNetRow)) * Table.Count() + sizeof(int);
			}
		}

		internal override IpNetTable Read(IntPtr pData)
		{
			var size = Marshal.ReadInt32(pData);
			var list = new List<IpNetRow>();
			var startAdress = IntPtr.Add(pData, sizeof(int));
			for (var i = 0; i < size; i++)
			{
				var row = new IpNetRow().Read(startAdress);
				list.Add(row);
			}
			return new IpNetTable { Table = list };
		}

		internal override IntPtr Write(IpNetTable obj)
		{
			var ptr = Marshal.AllocHGlobal(obj.Size);
			var wPtr = ptr;
			Marshal.WriteInt32(wPtr, obj.Table.Count());
			IntPtr.Add(wPtr, sizeof(int));
			foreach (var row in obj.Table)
			{
				Marshal.StructureToPtr(obj, wPtr, false);
				IntPtr.Add(wPtr, Marshal.SizeOf(typeof(IpNetRow)));
			}
			return ptr;
		}

		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.AppendFormat("ADR\t\t\tPHYS ADR\t\t\tTYPE{0}", Environment.NewLine);
			foreach (var row in Table)
			{
				sb.Append(row.ToString());
			}
			return sb.ToString();
		}
	}
}
