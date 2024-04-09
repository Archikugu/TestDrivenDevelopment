using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    public class StringHelper
    {

        // Requirements
        // 1. Extra spaces at the beginning and end of the input expression should be removed.
        // 2. Spaces inside the input expression should be removed.

        public static string RemoveExtraSpaces(string expression)
        {
            expression = expression.Trim();

            string newExpression = string.Empty;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == ' ' && expression[i + 1] == ' ')
                {
                    continue;
                }
                newExpression += expression[i];
            }
            return newExpression;
        }
    }
}
