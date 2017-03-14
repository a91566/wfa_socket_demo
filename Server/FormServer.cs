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

namespace Server
{
    public partial class FormServer : Form
    {
        private byte[] result = new byte[1024];
        private Socket _serverSocket;  

        public FormServer()
        {
            InitializeComponent();
            this.FormClosed += (s, e) =>
            {
                if (this._serverSocket != null)
                {
                    this._serverSocket.Dispose();
                }
            };
        }

      

        /// <summary>  
        /// 监听客户端连接  
        /// </summary>
        private void ListenClientConnect()
        {
            while (true)
            {
                Socket clientSocket = _serverSocket.Accept();
                clientSocket.Send(Encoding.ASCII.GetBytes("Server Say Hello"));
                Thread receiveThread = new Thread(ReceiveMessage);
                receiveThread.Start(clientSocket);
            }
        }

        /// <summary>  
        /// 接收消息  
        /// </summary>  
        /// <param name="clientSocket"></param>
        private void ReceiveMessage(object clientSocket)
        {
            Socket myClientSocket = (Socket)clientSocket;
            while (true)
            {
                try
                {
                    //通过clientSocket接收数据  
                    int receiveNumber = myClientSocket.Receive(result);
                    this.output(string.Format("接收客户端{0}消息：{1}", myClientSocket.RemoteEndPoint.ToString(), Encoding.ASCII.GetString(result, 0, receiveNumber)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    myClientSocket.Shutdown(SocketShutdown.Both);
                    myClientSocket.Close();
                    break;
                }
            }
        }

        private void output(string text)
        {
            this.textBox1.Text += text + "\r\n";
            this.textBox1.SelectionStart = this.textBox1.Text.Length;
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            //服务器IP地址  
            IPAddress ip = IPAddress.Parse("127.0.0.1");
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(ip, Convert.ToInt16(this.txbPort.Text)));  //绑定IP地址：端口  
            _serverSocket.Listen(10);    //设定最多10个排队连接请求  
            this.output(string.Format("启动监听端口号{0}成功。", _serverSocket.LocalEndPoint.ToString()));
            //通过Clientsoket发送数据  
            Thread myThread = new Thread(ListenClientConnect);
            myThread.Start();
        }

       
    }
}
