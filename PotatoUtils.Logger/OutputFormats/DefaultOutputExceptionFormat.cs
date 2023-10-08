using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public class DefaultOutputExceptionFormat : OutputFormat
    {
        public override MessageInfo Process(string message, string callerFileName, string callerMethodName)
        {
            string callerClass = FilterCallerFileName(callerFileName);
            string finalMessage = $"{DateTime.Now} -- EXCEPTION -- In module {{{callerClass}}} calling method {{{callerMethodName}()}}" +
                $" -- exception message :{message}";

            return new MessageInfo(finalMessage);
        }
    }
}
