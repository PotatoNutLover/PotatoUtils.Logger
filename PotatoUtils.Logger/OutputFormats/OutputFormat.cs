using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public abstract class OutputFormat
    {
        public virtual MessageInfo Process(string message, string callerFileName, string callerMethodName)
        {
            string callerClass = FilterCallerFileName(callerFileName);
            string finalMessage = $"{DateTime.Now} -- In module {{{callerClass}}} calling method {{{callerMethodName}()}}" +
                $" -- message: {message}";

            return new MessageInfo(finalMessage);
        }

        private protected string FilterCallerFileName(string callerFileName)
        {
            int count = callerFileName.Count(x => x == '\\');
            string[] strings = callerFileName.Split('\\');
            return $"{strings[count - 1]}.{strings[count]}";
        }
    }
}
