using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "go to your c:\\ Drive";
            //string myString = string.Format("{0}!", "bonzai");

            //int var = 12345678;

            //string myString = string.Format("{0:N}", var);

            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString +=  "-" + i.ToString();
            }

            Console.WriteLine(myString);
            Console.ReadLine();


        }
    }
}
