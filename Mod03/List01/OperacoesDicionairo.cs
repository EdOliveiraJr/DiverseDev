using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01
{
    internal class OperacoesDicionairo
    {
        public static Dictionary<string, int> ContarPalavras(string texto)
        {
            Dictionary<string, int> contador = new Dictionary<string, int>();

            string[] palavras = texto.Split(new char[] { ' ', ',', '.', ';', ':', '(', ')', '[', ']', '{', '}', '-', '_', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string palavra in palavras)
            {
                string palavraNormalizada = palavra.ToLower();

                if (contador.ContainsKey(palavraNormalizada))
                {
                    contador[palavraNormalizada]++;
                }
                else
                {
                    contador[palavraNormalizada] = 1;
                }
            }

            return contador;
        }

        public static void MostrarContagem(Dictionary<string,int> dict) 
        {
            Console.WriteLine("Contagem de Palavras: ");
            foreach(var par in  dict) 
            {
                Console.WriteLine($"{par.Key}: {par.Value}");
            }
        }
    }
}
