using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Collections.Generic;

namespace RdpWindowsManager.Controls
{
   public class RdpTreeView : TreeView
   {
      public RdpTreeView()
      {
         DrawMode = TreeViewDrawMode.OwnerDrawText;
      }

      [Browsable(false)]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public new bool FullRowSelect { get; set; }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool SelectFullRow { get; set; }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectNodeBackColor { get; set; } = Color.FromArgb(82, 156, 215);

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color SelectNodeForeColor { get; set; } = Color.White;

      protected override void OnDrawNode(DrawTreeNodeEventArgs e)
      {
         Font font = e.Node.NodeFont;

         e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
         e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

         if (e.Node == e.Node.TreeView.SelectedNode)
         {
            using (SolidBrush brush = new SolidBrush(SelectNodeBackColor))
            {
               if (SelectFullRow)
               {
                  e.Graphics.FillRectangle(brush, new RectangleF(0, e.Bounds.Y, Width, e.Bounds.Height));
               }
               else
               {
                  e.Graphics.FillRectangle(brush, e.Bounds);
               }
            }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, SelectNodeForeColor, TextFormatFlags.GlyphOverhangPadding);
         }
         else
         {
            using (SolidBrush brush = new SolidBrush(BackColor))
            {
               e.Graphics.FillRectangle(brush, e.Bounds);
            }

            TextRenderer.DrawText(e.Graphics, e.Node.Text, font, e.Bounds, e.Node.ForeColor, TextFormatFlags.GlyphOverhangPadding);
         }
      }

      public IEnumerable<string> GetNodesText(TreeNodeCollection nodes)
      {
         foreach (TreeNode item in nodes)
         {
            yield return item.Text;
         }
      }
   }
}
