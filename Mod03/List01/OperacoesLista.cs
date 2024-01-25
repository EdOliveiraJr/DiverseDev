using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01
{
    internal static class OperacoesLista
    {
        public static List<string> MaioresQueDez(List<string> list) 
        {  
            List<string> result = new List<string>();

            foreach (string str in list) 
            {
                if(str.Length >= 10)
                {
                    result.Add(str);            
                }
            }
            return result;
        }

        public static void MostraLista(List<string> list) 
        {
            Console.Write("{ ");
            foreach (string str in list)
            {
                Console.Write(str + " ");
            }
            Console.Write(" }\n");
        }
    }
}
