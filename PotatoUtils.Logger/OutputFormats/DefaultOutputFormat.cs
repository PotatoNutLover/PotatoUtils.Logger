using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public class DefaultOutputFormat : OutputFormat
    {
        public override MessageInfo Process(string message, string callerFileName, string callerMethodName)
        {
            return base.Process(message, callerFileName, callerMethodName);
        }
    }
}
