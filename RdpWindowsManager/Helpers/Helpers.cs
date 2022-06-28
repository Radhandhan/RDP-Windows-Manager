using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Soap;

namespace RdpWindowsManager
{
   internal static class Helpers
   {
      public static Color SelectColor()
      {
         using (ColorDialog dialog = new ColorDialog())
         {
            dialog.FullOpen = true;
            return dialog.ShowDialog() == DialogResult.OK ? dialog.Color : Color.Black;
         }
      }

      public static void XmlSerialize<T>(T value, string path)
      {
         SoapFormatter sf = new SoapFormatter();

         using (FileStream reader = new FileStream(path, FileMode.Create, FileAccess.Write))
         {
            sf.Serialize(reader, value);
         }
      }

      public static T XmlDeserialize<T>(string path)
      {
         SoapFormatter sf = new SoapFormatter();

         using (FileStream reader = new FileStream(path, FileMode.Open))
         {
            return (T)sf.Deserialize(reader);
         }
      }
   }
}
