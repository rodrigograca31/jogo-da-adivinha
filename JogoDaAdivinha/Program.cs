using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace JogoDaAdivinha
{
    class Program
    {
        static void Main(string[] args)
        {
            int limInf = 0;
            int limSup = 5;
            int numTent = 3;
            int meuNumero = 0;

            Jogo j = new Jogo(limSup, limInf, numTent);

            Console.WriteLine("Acabei de pensar num número entre {0} e {1}.\nConsegue adivinhá-lo em {2} tentativas?", limInf, limSup, numTent);

            while (j.PodeJogar())
            {
                try
                {
                    meuNumero = int.Parse(Console.ReadLine());

                    if (j.Tentativa(meuNumero) == true)
                    {
                        Console.WriteLine("Parabéns!\nAcertou em cheio!");
                        Console.Read();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("O seu número é {0} que o meu.", j.Ajuda());
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Cuidado, deve inserir um número!");
                }

            }
            Console.WriteLine("Dogh!");
        }
    }
}
