using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_5
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private StringBuilder _log;

        static Logger()
        {
        }

        public Logger()
        {
            _log = new StringBuilder();
        }

        public string LogDoc
        {
           get { return _log.ToString(); }
        }

        public static Logger Instance
        {
            get { return _instance; }
        }

        public void Info(string value)
        {
            string type = "Info";
            Log(type, value);
        }

        public void Warneng(string value)
        {
            string type = "Warning";
            Log(type, value);
        }

        public void Erorr(string value)
        {
            string type = "Erorr";
            Log(type, value);
        }

        public void Log(string type, string value)
        {
            string res = $"{DateTime.Now}:{type}:{value}";
            Console.WriteLine(res);
            _log.AppendLine(res);
            File.WriteAllText("log.txt", LogDoc);
        }
    }
}
