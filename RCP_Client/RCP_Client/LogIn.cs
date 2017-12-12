using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace RCP_Client
{
    class LogIn
    {
        string host = "127.0.0.1";
        int port = Convert.ToInt16(12345);
        TcpClient ClientConn;
        
        public LogIn(string userName, string userPasswd)
        {
            Connect();
        }

        private bool Connect()
        {
            try
            {
                ClientConn = new TcpClient(host, port);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        private bool Authorise()
        {
            // ToDo

            return false;
        }

    }
}
