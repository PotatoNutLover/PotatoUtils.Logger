using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotatoUtils.Logger.Utils
{
    public class StringHolder
    {
        private string _value;

        public string Value
        {
            get => _value;
            set => _value = value;
        } 

        public StringHolder (string value)
        {
            _value = value;
        }
    }
}
