using System;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace RdpWindowsManager.Controls
{
   [Serializable]
   public class RdpTreeNode : TreeNode
   {
      public string Host { get; set; }
      public int Port { get; set; }
      public string Username { get; set; }
      public string Password { get; set; }

      public RdpTreeNode() { }

      public RdpTreeNode(string text)
      {
         Text = text;
      }

      protected RdpTreeNode(SerializationInfo si, StreamingContext context) : base(si, context)
      {
         Host = si.GetString("Host");
         Username = si.GetString("Username");
         Password = si.GetString("Password");
         Port = si.GetInt32("Port");
      }

      protected override void Serialize(SerializationInfo si, StreamingContext context)
      {
         base.Serialize(si, context);
         si.AddValue("Host", Host);
         si.AddValue("Username", Username);
         si.AddValue("Password", Password);
         si.AddValue("Port", Port);
      }
   }
}
