using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace SysLog_Remote_Store_Application
{
    internal abstract class NetworkProtocols
    {
        protected string networkIPAddress;

        protected int networkPort;

        protected NetworkProtocols(string networkIPAddress, int networkPort)
        {
            this.networkIPAddress = networkIPAddress;
            this.networkPort = networkPort;
        }

        public abstract string NetworkListener(string networkIPAddress, int networkPort);
    }
}
