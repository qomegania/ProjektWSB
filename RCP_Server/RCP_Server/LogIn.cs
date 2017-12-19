using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace RCP_Server
{
    class LogIn
    {
        IPAddress addressIP = IPAddress.Parse("127.0.0.1");
        int port = Convert.ToInt16(12345);
        private TcpListener listener;
        private TcpClient client;

        public LogIn()
        {
            Connect();
        }

        public bool isConnected
        {
            get;
            set;
        }

        private bool Connect()
        {
            try
            {
                listener = new TcpListener(addressIP, port);
                listener.Start();
                client = listener.AcceptTcpClient();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private bool Authorise()
        {

            // TODO

            return false;
        }

        private bool Disconnect()
        {

            // TODO

            return false;
        }
    }
}
