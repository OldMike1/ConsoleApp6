using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Timernew
    {
        protected string _sec;
        public string _sec1;

        public string Sec
        {
            set
            {
                _sec = value;
            }
            get
            {
                if (int.Parse(_sec) >= 60)
                {
                    _sec1 = Convert.ToString(int.Parse(_sec) % 60);
                    _sec = Convert.ToString(int.Parse(_sec) / 60);
                    return _sec + "," + _sec1;
                }
                else
                    return _sec;
            }
        }
    }
}
