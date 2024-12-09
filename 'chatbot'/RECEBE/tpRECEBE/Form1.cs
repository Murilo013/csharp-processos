using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace tpRECEBE
{
    public partial class Form1 : Form
    {
        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
        EndPoint enderecoRecebe = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
        EndPoint enderecoEnvia = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 4040);
        byte[] data = new byte[1024];
        int qtdbytes;
        Thread mythread;
        int i = 0;
        Boolean flag = true;

        public Form1()
        {
            InitializeComponent();
            socket.Bind(enderecoRecebe);
        }

        private void meuProcesso()
        {
            while (flag)
            {
                qtdbytes = socket.ReceiveFrom(data, ref enderecoRecebe);
                string msg = Encoding.ASCII.GetString(data, 0, qtdbytes);
                listmsg.Invoke((Action)delegate ()
                {
                    listmsg.Items.Add(msg);
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mythread = new Thread(new ThreadStart(this.meuProcesso));
            flag = true;
            mythread.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            socket.SendTo(Encoding.ASCII.GetBytes("Amiguinho: " + msg.Text), enderecoEnvia);

            listmsg.Items.Add("Você: " + msg.Text);
        }
    }
}
