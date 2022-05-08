using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Starter
    {
        private Actions _actions;

        public Starter()
        {
            _actions = new Actions();
        }

        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                Random random = new Random();
                int rn = random.Next(1, 4);
                switch (rn)
                {
                    case 1:
                        _actions.Method1();
                        break;
                    case 2:
                        _actions.Method2();
                        break;
                    case 3:
                        _actions.Method3();
                        break;
                }
            }
        }
    }
}
