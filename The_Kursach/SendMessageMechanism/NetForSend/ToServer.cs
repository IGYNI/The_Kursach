using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace The_Kursach.SendMessageMechanism.NetForSend
{
    internal class ToServer
    {
        TcpClient _currentClient;

        public ToServer()
        {
            _currentClient = new TcpClient();
        }

        public void ConnectToServer(string ip, int port)
        {
            if(!_currentClient.Connected)
                _currentClient.Connect(ip, port);
        }

    }
}
