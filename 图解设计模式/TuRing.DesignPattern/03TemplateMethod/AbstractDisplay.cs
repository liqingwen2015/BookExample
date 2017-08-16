using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TemplateMethod
{
    abstract class AbstractDisplay
    {
        public void Display()
        {
            Open();

            for (var i = 0; i < 5; i++)
            {
                Print();
            }
            
            Close();
        }

        protected abstract void Open();

        protected abstract void Print();

        protected abstract void Close();
    }
}
