using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger.OutputStreams
{
    public class EventOutputStream : IOutputStream
    {
        public delegate void LogHandler(string message);
        public event LogHandler? OnMessageLogged;

        public void WriteMessage(MessageInfo messageInfo)
        {
            OnMessageLogged?.Invoke(messageInfo.Message);
        }
    }
}
