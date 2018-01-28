using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace TestDll
{
	public interface IClass
	{
		int add(int a, int b);
	}
	[ClassInterface(ClassInterfaceType.None)]
	public class Class1 : IClass
	{
		public int add(int a, int b)
		{
			return a + b;
		}
	}
}
