using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse
{
    public class Reverse 
    {
        public static string ReverseThis(string input)
        {
            string reversed="";
            
            for (int i=input.Length-1; i>=0; i--)
            {
                reversed += input[i];

            }
            return reversed;
        }
        static void Main(string[] args)
        {
        }
    }
}
