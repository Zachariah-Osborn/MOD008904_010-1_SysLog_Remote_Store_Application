using System;
using System.Collections.Generic;
using System.Text;

namespace SysLog_Remote_Store_Application
{
    internal class UserDatagramProtocol : NetworkProtocols
    {
        public UserDatagramProtocol(string networkIPAddress, int networkPort) : base(networkIPAddress, networkPort)
        {

        }

        public override string NetworkListener(string networkIPAddress, int networkPort)
        {
            return "";
        }
    }
}
