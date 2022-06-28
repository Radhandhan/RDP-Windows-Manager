using System;
using System.Globalization;
using System.ComponentModel;

namespace RdpWindowsManager.Controls.Suite
{
   internal class ExpandableObject : ExpandableObjectConverter
   {
      public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
      {
         return destinationType == typeof(string) ? "" : base.ConvertTo(context, culture, value, destinationType);
      }
   }
}
