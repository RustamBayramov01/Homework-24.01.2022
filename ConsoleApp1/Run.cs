using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




delegate void Runn();

namespace ConsoleApp1
{
    class Run
    {

        MyClass myClass;
        
        static event Runn r;

        string strCopy = "";

        public void Path()
        {
            myClass = new(strCopy);
            myClass.Space(strCopy);
            myClass.Reverse(strCopy);
        }


        public void runFunc(string str)
        {
            
            strCopy = str;
            
            r += Path;
            
            r();
        
        }

    }

}
