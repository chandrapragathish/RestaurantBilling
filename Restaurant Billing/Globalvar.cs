using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_Billing
{
    class Globalvar
    {
        private static Int64 _kot =0;
        public static Int64 kot
        {
            get { return _kot; }
            set { _kot = value; }
        }

    }
}

