using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TemplateMethod
{
    class StringDisplay:AbstractDisplay
    {
        private readonly string _msg;
        private readonly int _length;

        public StringDisplay(string msg)
        {
            _msg = msg;
            _length = msg.Length;
        }

        protected override void Open()
        {
            PrintChar();
        }

        protected override void Print()
        {
            Console.WriteLine(_msg);
        }

        protected override void Close()
        {
            PrintChar();
        }

        private void PrintChar()
        {
            Console.Write("+");

            for (var i = 0; i < _length; i++)
            {
                Console.Write("-");
            }

            Console.WriteLine("+");
        }
    }
}
