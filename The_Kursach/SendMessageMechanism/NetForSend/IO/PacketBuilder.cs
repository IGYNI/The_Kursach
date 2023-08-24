using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Remoting.Messaging;

namespace The_Kursach.SendMessageMechanism.NetForSend.IO
{
    internal class PacketBuilder
    {
        MemoryStream _ms;
        public PacketBuilder()
        {
            _ms = new MemoryStream();
        }

        public void WriteOpCode(byte opcode)
        { 
            _ms.WriteByte(opcode);
        }

        public void WriteString(string msg) 
        {
            var msgLength = msg.Length;
            _ms.Write(BitConverter.GetBytes(msgLength), 0, 4);
            _ms.Write(Encoding.ASCII.GetBytes(msg), 0, msgLength);
        }

        public byte[] GetPacketBytes() => _ms.ToArray();

    }
}
