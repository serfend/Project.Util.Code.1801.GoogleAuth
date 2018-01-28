using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace GoogleAuth
{
	public interface IAuth
	{
		void SetIdentity(string Identity);
		void SetSecretBase32(string SecretBase32);
		string QRCodeUrl();
		int OneTimePassword();
	}
	[ClassInterface(ClassInterfaceType.None)]
	public class Auth :IAuth
	{
		private GoogleAuther.GoogleAuthMain Auther=new GoogleAuther.GoogleAuthMain();


		public int OneTimePassword()
		{
			return Auther.OneTimePassword;
		}

		public string QRCodeUrl()
		{
			return Auther.QRCodeUrl;
		}

		public void SetIdentity(string Identity)
		{
			Auther.Identity = Identity;
		}

		public void SetSecretBase32(string SecretBase32)
		{
			Auther.SecretBase32 = SecretBase32;
		}
	}
}
