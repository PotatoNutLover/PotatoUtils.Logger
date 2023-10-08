using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger
{
    public interface IOutputStream
    {
        public void WriteMessage(MessageInfo messageInfo);
    }
}
