using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ServidorRecebe
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream iofile;
            int tam;
            char x;
            string txt = "";

            Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            byte[] data = new byte[1024];
            int  qtdbytes;

            socketreceber.Bind(endereco);
            while (true)
            {
                 qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                 Console.WriteLine(Encoding.ASCII.GetString(data, 0, qtdbytes));


                iofile = new System.IO.FileStream(@"C:\Users\unisanta\Downloads\testeJSON.json",
                                                   System.IO.FileMode.Create,
                                                   System.IO.FileAccess.Write);
                for (int i = 0; i < qtdbytes; i++)
                {
                    iofile.WriteByte(data[i]);
                }
                iofile.Close();              
            }
        }
    }
}
