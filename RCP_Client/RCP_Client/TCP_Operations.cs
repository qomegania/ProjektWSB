using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RCP_Client
{
    static class TCP_Operations
    {
        public enum operations : int
        {
            LogIn = 0000,
            GetList = 0001,
            StartTask = 0010,
            EndTask = 0011,
            GetCommentList = 0100,
            SendComment = 0101,
            GetMessageList = 0110,
            SendMessage = 0111,
            GetUserList = 1000,
            SendMyUserName = 1001,
            ChangePasswd = 1010,



            LogOut = 1111


        }

    }
}
