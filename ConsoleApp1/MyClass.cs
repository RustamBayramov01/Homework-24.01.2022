using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyClass
    {
        
        public string Text { get; set; }

        public MyClass(string text) { Text = text; }


        public void Space(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (i == str.Length - 1)
                {
                    result += Text[i];
                    break;
                }
                result += Text[i] + "_";
            }
            
            Console.WriteLine(result);
        
        }


        public void Reverse(string str)
        {
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                result += str[(str.Length - 1) - i];
            }

            Console.WriteLine(result);

        }


    }
}
