using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_task5_string
{
    internal class InputManager
    {
        public void Convert(ref string expression)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char symbol in expression)
            {
                if (char.IsDigit(symbol) || symbol == '+' || symbol == '-')
                {
                    sb.Append(symbol);
                }
            }

            expression = sb.ToString();
        }
    }
}
