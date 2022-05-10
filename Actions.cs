using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW_5
{
    public class Actions
    {
        private Logger _logger;

        public Actions()
        {
            _logger = new Logger();
        }

        public Result StartMethod()
        {
            _logger.Info("Start method");
            return new Result() { Status = true };
        }

        public Result SkippedLogicInMethod()
        {
            _logger.Warneng("Start method");
            return new Result() { Status = true };
        }

        public Result BrokeLogic()
        {
            _logger.Erorr("I broke a logic");
            return new Result() { ErrorMasseg = "I broke a logic", Status = false };
        }
    }
}
