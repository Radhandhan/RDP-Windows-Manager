using MSTSCLib;
using AxMSTSCLib;

namespace RdpWindowsManager.Controls
{
   public class RdpClient : AxMsRdpClient6NotSafeForScripting
   {
      public void ConnectServer(string host, string username, string password, int port = 3389)
      {
         IMsRdpClientNonScriptable4 ocx = (IMsRdpClientNonScriptable4)GetOcx();

         ocx.EnableCredSspSupport = true;
         ocx.AllowCredentialSaving = false;
         ocx.PromptForCredentials = false;
         ocx.PromptForCredsOnClient = false;

         base.Server = host;
         base.UserName = username;
         base.AdvancedSettings7.RDPPort = port;
         base.AdvancedSettings7.ClearTextPassword = password;
         base.Connect();
      }
   }
}
