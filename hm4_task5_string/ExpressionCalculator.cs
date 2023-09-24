using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm4_task5_string
{
    internal class ExpressionCalculator
    {
        public int Result { get; set; }
        public void Calculate(string expression)
        {
            StringBuilder sb = new StringBuilder();

            int nextCompound = 0;
            char mathOperator = ' ';

            foreach (char symbol in expression)
            {
                if (char.IsDigit(symbol))
                {
                    sb.Append(symbol);
                }

                else if (!char.IsDigit(symbol))
                {
                    nextCompound = int.Parse(sb.ToString());

                    if (Result == 0 && nextCompound != 0)
                    {
                        Result = nextCompound;
                        nextCompound = 0;
                    }

                    else if (Result != 0 && nextCompound != 0)
                    {
                        if (mathOperator == '+')
                        {
                            Result += nextCompound;
                        }
                        else if (mathOperator == '-')
                        {
                            Result -= nextCompound;
                        }
                    }

                    sb.Clear();

                    if (symbol == '+' || symbol == '-')
                    {
                        mathOperator = symbol;
                    }
                }
            }

            if (sb.Length > 0)
            {
                nextCompound = int.Parse(sb.ToString());

                if (mathOperator == '+')
                {
                    Result += nextCompound;
                }

                else if (mathOperator == '-')
                {
                    Result -= nextCompound;
                }
            }
        }
    }
}
