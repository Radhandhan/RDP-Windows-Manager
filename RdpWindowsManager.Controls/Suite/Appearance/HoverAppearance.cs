using System.Drawing;
using System.ComponentModel;

namespace RdpWindowsManager.Controls.Suite.Appearance
{
   [TypeConverter(typeof(ExpandableObject))]
   public class HoverAppearance
   {
      [Browsable(true)]
      [NotifyParentProperty(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public int BorderSize { get; set; }

      [Browsable(true)]
      [NotifyParentProperty(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderColor { get; set; }
   }
}
