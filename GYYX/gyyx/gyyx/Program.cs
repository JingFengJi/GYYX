using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyyx
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMaxLenSubStr(Console.ReadLine()));
            Console.ReadKey();
        }

        static int GetMaxLenSubStr (string str)
        {
            if (str == null || str.Length <= 0)
            {
                return 0;
            }
            int max = 1;
            int temp = 0;
            ArrayList list = new ArrayList();
            char[] charArray = str.ToCharArray();
            for (int i = 0; i < str.Length; i++)
            {
                if (str.Substring(i).Length < max)
                {
                    return max;
                }
                list.Add(charArray[i]);
                temp = 1;
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (!list.Contains(charArray[j]))
                    {
                        temp++;
                        list.Add(charArray[j]);
                    }
                    else
                    {
                        break;
                    }
                }
                if (temp >= max)
                {
                    max = temp;
                }
                temp = 0;
                list.Clear();
            }
            
            return max;
        }
    }
}
