using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List01
{
    internal static class OperacoesPilha
    {
        public static bool VerificarExpressaoBalanceada(string expressao)
        {
            Stack<char> pilha = new Stack<char>();

            foreach (char caractere in expressao)
            {
                if (caractere == '(' || caractere == '{' || caractere == '[')
                {
                    pilha.Push(caractere);
                }
                else if (caractere == ')' || caractere == '}' || caractere == ']')
                {
                    if (pilha.Count == 0)
                    {
                        return false;
                    }

                    char topoDaPilha = pilha.Pop();

                    if ((topoDaPilha == '(' && caractere != ')') ||
                        (topoDaPilha == '{' && caractere != '}') ||
                        (topoDaPilha == '[' && caractere != ']'))
                    {
                        return false; 
                    }
                }
            }

            return pilha.Count == 0;
        }
    }
}
