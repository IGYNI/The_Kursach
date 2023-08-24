using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using The_Kursach.SendMessageMechanism.NetForSend.IO;
using The_Server_For_The_Kursach.Net.IO;

namespace The_Kursach.SendMessageMechanism.NetForSend
{
    internal class ToServer
    {
        TcpClient _currentClient;
        public PacketReader PacketReader;

        public Action msgReveivedEvent;

        public ToServer()
        {
            _currentClient = new TcpClient();
        }

        public void ConnectToServer(string ip, int port, int id)
        {
            if (!_currentClient.Connected)
            {
                _currentClient.Connect(ip, port);
                PacketReader = new PacketReader(_currentClient.GetStream());
                var connectPacket = new PacketBuilder();
                connectPacket.WriteOpCode(0);
                connectPacket.WriteString(System.Convert.ToString(id));
                _currentClient.Client.Send(connectPacket.GetPacketBytes());
                ReadPackets();
            }
            
        }

        public void SendMessage(string message)
        { 
            var messagePacket = new PacketBuilder();
            messagePacket.WriteOpCode(5);
            messagePacket.WriteString(message);
            _currentClient.Client.Send(messagePacket.GetPacketBytes());
        }

        private void ReadPackets()
        {
            Task.Run(() => 
            {
                while (true) 
                {
                    var opcode = PacketReader.ReadByte();
                    switch (opcode) 
                    {
                        case 5:
                            msgReveivedEvent?.Invoke();
                            break;
                    }
                }
            
            
            });
        }
    }
}

