using NUnit.Framework;
using Pixills.Interop.Networking;
using Pixills.Interop.Types;
using System;
using System.Diagnostics;

namespace Pixills.Interop.Tests
{
	[TestFixture]
	public class NetworkingTests
	{
		[Test]
		public void GetIpForwardTableTest()
		{
			var table = Ip.GetForwardTable();
			Debug.WriteLine(table.ToString());
			Assert.IsNotNull(table);
		}

		[Test]
		public void GetIpAddrTableTest()
		{
			var table = Ip.GetAddressTable();
			Debug.WriteLine(table.ToString());
			Assert.IsNotNull(table);
		}

		[Test]
		public void GetIpNetTableTest()
		{
			var table = Ip.GetNetTable();
			Debug.WriteLine(table.ToString());
			Assert.IsNotNull(table);
		}
	}
}
