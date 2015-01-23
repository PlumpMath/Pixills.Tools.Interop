using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Pixills.Interop.Networking
{
	public abstract class Marshallable<T>
	{
		internal abstract int Size { get; }

		internal abstract T Read(IntPtr pData);

		internal abstract IntPtr Write(T managedData);
	}
}
