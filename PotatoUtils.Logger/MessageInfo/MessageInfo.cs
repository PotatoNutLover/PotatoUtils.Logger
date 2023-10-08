using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public class MessageInfo
    {
        private readonly string _message;

        public string Message
        {
            get => _message;
        }

        public MessageInfo(string message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }
    }
}
