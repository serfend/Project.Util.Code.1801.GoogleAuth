using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DotNet4.Utilities.UtilReg;
using GoogleAuther;
namespace GoogleAuthCmd
{
	class Program
	{
		static void Main(string[] args)
		{
			if (args.Length <2)
			{
				InvalidCmd();
				return;
			}
			string method = args[0];
			string info = args[1];
			switch (method)
			{
				case "SetI": {

						break;
					}
				case "SetP":
					{

						break;
					}
				case "GetK":
					{

						break;
					}
				case "GetU":
					{

						break;
					}
				default:
					{
						InvalidCmd();
						break;
					}
			}
		}
		static void InvalidCmd()
		{
			System.Windows.Forms.MessageBox.Show("请联系qq331945833获取正确使用方法");
		}
	}
}
