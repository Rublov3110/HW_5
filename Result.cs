using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_5
{
    public class Result
    {
        private bool _status;

        private string _errorMasseg = " ";

        public bool Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string ErrorMasseg
        {
           get { return _errorMasseg; }
           set { _errorMasseg = value; }
        }
    }
}
