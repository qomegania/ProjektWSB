using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitString;

            do
            {
                exitString = "";
                LogIn server = new LogIn();

                Console.WriteLine(server.isConnected);

                //Console.Write("Press any key to continue, else type STOP or EXIT");
                //exitString = Console.ReadLine();
            } while (exitString.ToUpper() != "STOP" || exitString.ToUpper() != "EXIT");

        }
    }
}
