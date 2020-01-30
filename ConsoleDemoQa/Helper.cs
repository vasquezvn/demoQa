using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemoQa
{
    public class Helper
    {
        public static string GetRandomString(int size, bool lowerCase = false)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;

            for(int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            if(lowerCase)
            {
                return builder.ToString().ToLower();
            }

            return builder.ToString();
        }

        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();

            return random.Next(min, max);
        }
    }
}
