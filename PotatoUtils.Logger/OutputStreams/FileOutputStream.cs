using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PotatoUtils.Logger
{
    public class FileOutputStream : IOutputStream
    {
        private readonly string _filePath;

        public FileOutputStream(string path)
        {
            _filePath = path;
        }

        public void WriteMessage(MessageInfo messageInfo)
        {
            using (StreamWriter writer = new StreamWriter(_filePath, true))
            {
                writer.WriteLine(messageInfo.Message);
            }
        }
    }
}
