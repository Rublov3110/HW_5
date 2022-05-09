using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_5
{
    public class Starter
    {
        private Actions _actions;
        private Logger _logger;

        public Starter()
        {
            _actions = new Actions();
            _logger = new Logger();
        }

        public void Run()
        {
            for (int i = 0; i < 10; i++)
            {
                Random random = new Random();
                int rn = random.Next(1, 4);
                switch (rn)
                {
                    case 1:
                        _actions.StartMethod();
                        break;
                    case 2:
                        _actions.SkippedLogicInMethod();
                        break;
                    case 3:
                        _actions.BrokeLogic();
                        break;
                }
            }
        }

        File.File.WriteAllText("log.txt" _logger.Word);
    }
}
