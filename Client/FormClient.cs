using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading; 

namespace Client
{
    public partial class FormClient : Form
    {
        private static byte[] result = new byte[1024];
        private Socket _clientSocket;
        public FormClient()
        {
            InitializeComponent();
            this.txbSend.Text = "Hello";
            this.FormClosed += (s, e) =>
            {
                if (this._clientSocket != null)
                {
                    this._clientSocket.Dispose();
                }
            };
        }

     

        private void output(string text)
        {
            this.textBox1.Text += text + "\r\n";
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            //设定服务器IP地址  
            IPAddress ip = IPAddress.Parse(this.txbIP.Text.Trim());
            this._clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                this._clientSocket.Connect(new IPEndPoint(ip, Convert.ToInt16(this.txbPort.Text.Trim()))); //配置服务器IP与端口  
                this.output(string.Format("连接服务器成功"));
                this.btnLink.Enabled = false;
            }
            catch
            {
                this.output(string.Format("连接服务器失败，请按回车键退出！"));
                return;
            }
            //通过clientSocket接收数据  
            int receiveLength = this._clientSocket.Receive(result);
            this.output(string.Format("连接成功，收到服务器消息：{0}", Encoding.ASCII.GetString(result, 0, receiveLength)));
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                string sendMessage = string.Format("{0} By DateTime:{1}", this.txbSend.Text.Trim(), DateTime.Now);
                this._clientSocket.Send(Encoding.ASCII.GetBytes(sendMessage));
                this.output(string.Format("向服务器发送消息：{0}", sendMessage));
                this.output("发送完毕.");
            }
            catch
            {
                this._clientSocket.Shutdown(SocketShutdown.Both);
                this._clientSocket.Close();
                this.btnLink.Enabled = true;
            }
        }

        private void btnDisconntect_Click(object sender, EventArgs e)
        {
            if (this._clientSocket.Connected)
                this._clientSocket.Disconnect(true);
        }
    }
}
