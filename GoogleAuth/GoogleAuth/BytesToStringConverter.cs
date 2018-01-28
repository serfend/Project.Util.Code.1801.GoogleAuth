using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Data;
using System.Globalization;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Windows.Markup;
using System.Runtime.Remoting;
namespace GoogleAuther
{
    [ValueConversion(typeof(byte[]), typeof(string))]
    public class BytesToStringConverter:IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
               return BytesToString((byte[])value);
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (((string)value).Length % 2 == 0)
                return StringToBytes((string)value);
            else
                return Binding.DoNothing;
        }



        // http://stackoverflow.com/a/2556329/1242
        public byte[] StringToBytes(string value)
        {
            try
            {
                SoapHexBinary shb = SoapHexBinary.Parse(value);
                return shb.Value;
            }
            catch (RemotingException)
            {
                return new byte[0];
            }
        }

        public string BytesToString(byte[] value)
        {
            SoapHexBinary shb = new SoapHexBinary(value);
            return shb.ToString();
        }
    }
}
