using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Actions
    {
        public Result Method1()
        {
            // Start method:
            return new Result() { Status = true };
        }

        public Result Method2()
        {
            // Skipped logic in method:
            return new Result() { Status = true };
        }

        public Result Method3()
        {
            return new Result() { ErrorMasseg = "I broke a logic", Status = false };
        }
    }
}
