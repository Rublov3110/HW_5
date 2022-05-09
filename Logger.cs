using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Logger
    {
        private static Logger _instance = new Logger();
        private string _word = " ";

        static Logger()
        {
        }

        public string Word
        {
            get { return _word; }
            set { _word = value; }
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
            var res = $"{DateTime.Now}:{type}:{value}";
            Console.WriteLine(res);
            _word = res;
        }
    }
}
