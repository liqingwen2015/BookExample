using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TemplateMethod
{
    class CharDisplay:AbstractDisplay
    {
        private readonly char _ch;

        public CharDisplay(char ch)
        {
            _ch = ch;
        }

        protected override void Open()
        {
            Console.Write("<<");
        }

        protected override void Print()
        {
            Console.Write(_ch);
        }

        protected override void Close()
        {
            Console.WriteLine(">>");
        }
    }
}
