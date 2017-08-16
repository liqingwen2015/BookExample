using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Adapter.委托
{
    class PrintBanner:Print
    {
        private readonly Banner _banner;

        public PrintBanner(string msg)
        {
            _banner = new Banner(msg);
        }

        public override void PrintWeak()
        {
            _banner.ShowWithParen();
        }

        public override void PrintStrong()
        {
            _banner.ShowWithAster();
        }
    }
}
