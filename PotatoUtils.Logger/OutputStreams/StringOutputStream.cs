using PotatoUtils.Logger.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public class StringOutputStream : IOutputStream
    {
        private readonly StringHolder _outputString;

        public StringOutputStream (StringHolder stringHolder)
        {
            _outputString = stringHolder;
        }

        public void WriteMessage(MessageInfo messageInfo)
        {
            _outputString.Value += $"{messageInfo.Message};\n";
        }
    }
}
