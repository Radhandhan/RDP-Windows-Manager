using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Drawing2D;

using RdpWindowsManager.Controls.Enums;
using RdpWindowsManager.Controls.Helpers;
using RdpWindowsManager.Controls.Suite.Appearance;

namespace RdpWindowsManager.Controls
{
   [DefaultEvent("DefaultTextChanged")]
   public partial class RdpTextBox : UserControl
   {
      public RdpTextBox()
      {
         InitializeComponent();

         textBox1.HandleCreated += TextBox_HandleCreated;

         HoverState = new HoverAppearance
         {
            BorderSize = 1,
            BorderColor = Color.FromArgb(82, 156, 215)
         };
      }

      public event EventHandler DefaultTextChanged;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public override Color BackColor
      {
         get => base.BackColor;
         set
         {
            base.BackColor = value;
            textBox1.BackColor = value;
         }
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public override Color ForeColor
      {
         get => base.ForeColor;
         set
         {
            base.ForeColor = value;
            textBox1.ForeColor = value;
         }
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public override Font Font
      {
         get => base.Font;
         set
         {
            base.Font = value;
            textBox1.Font = value;
         }
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public string DefaultText
      {
         get => textBox1.Text;
         set => textBox1.Text = value;
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool PasswordChar
      {
         get => textBox1.UseSystemPasswordChar;
         set => textBox1.UseSystemPasswordChar = value;
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool Multiline
      {
         get => textBox1.Multiline;
         set => textBox1.Multiline = value;
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public bool ReadOnly
      {
         get => textBox1.ReadOnly;
         set => textBox1.ReadOnly = value;
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public int BorderSize { get; set; } = 1;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public Color BorderColor { get; set; } = Color.FromArgb(64, 64, 64);

      private BorderMode _border;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public BorderMode BorderMode
      {
         get => _border;
         set
         {
            _border = value;
            Invalidate();
         }
      }

      private string _placeholder;

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      public string Placeholder
      {
         get => _placeholder;
         set
         {
            _placeholder = value;
            UpdatePlaceholder();
         }
      }

      [Browsable(true)]
      [EditorBrowsable(EditorBrowsableState.Always)]
      [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
      public HoverAppearance HoverState { get; set; }

      protected override void OnPaint(PaintEventArgs e)
      {
         base.OnPaint(e);

         int borderSize = _isHover ? HoverState.BorderSize : BorderSize;
         Color borderColor = _isHover ? HoverState.BorderColor : BorderColor;

         switch (_border)
         {
            case BorderMode.Default:
               {
                  if (borderSize >= 1)
                  {
                     using (Pen border = new Pen(borderColor, borderSize))
                     {
                        border.Alignment = PenAlignment.Inset;

                        e.Graphics.SmoothingMode = SmoothingMode.None;
                        e.Graphics.DrawRectangle(border, 0, 0, Width - 0.5F, Height - 0.5F);
                     }
                  }
               }
               break;

            case BorderMode.Underline:
               {
                  using (Pen border = new Pen(borderColor, borderSize))
                  {
                     e.Graphics.SmoothingMode = SmoothingMode.None;

                     if (borderSize >= 1)
                     {
                        e.Graphics.DrawLine(border, 0, Height - borderSize, Width, Height - borderSize);
                     }
                  }
               }
               break;

            default: break;
         }
      }

      protected override void OnResize(EventArgs e)
      {
         base.OnResize(e);

         if (DesignMode)
         {
            UpdateControlHeight();
         }
      }

      protected override void OnLoad(EventArgs e)
      {
         base.OnLoad(e);
         UpdateControlHeight();
      }

      protected override void OnHandleCreated(EventArgs e)
      {
         base.OnHandleCreated(e);
         Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
      }

      private void Container_BackColorChanged(object sender, EventArgs e)
      {
         Invalidate();
      }

      private void UpdatePlaceholder()
      {
         if (textBox1.IsHandleCreated && _placeholder != null)
         {
            _ = Imports.SendMessage(textBox1.Handle, 0x1501, (IntPtr)1, _placeholder);
         }
      }

      private void UpdateControlHeight()
      {
         if (textBox1.Multiline == false)
         {
            textBox1.Multiline = true;
            textBox1.MinimumSize = new Size(0, TextRenderer.MeasureText("Text", Font).Height + 1);
            textBox1.Multiline = false;
            Height = textBox1.Height + Padding.Top + Padding.Bottom;
         }
      }

      private void TextBox_HandleCreated(object sender, EventArgs e)
      {
         base.OnHandleCreated(e);
         UpdatePlaceholder();
      }

      private void TextBox1_Click(object sender, EventArgs e)
      {
         OnClick(e);
      }

      private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
      {
         OnKeyPress(e);
      }

      private void TextBox1_MouseEnter(object sender, EventArgs e)
      {
         OnMouseEnter(e);
      }

      private void TextBox1_MouseLeave(object sender, EventArgs e)
      {
         OnMouseLeave(e);
      }

      private bool _isHover;

      private void TextBox1_Enter(object sender, EventArgs e)
      {
         _isHover = true;
         Invalidate();
      }

      private void TextBox1_Leave(object sender, EventArgs e)
      {
         _isHover = false;
         Invalidate();
      }

      private void TextBox1_TextChanged(object sender, EventArgs e)
      {
         DefaultTextChanged?.Invoke(sender, e);
      }
   }
}
