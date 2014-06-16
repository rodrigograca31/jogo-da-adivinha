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

            Console.WriteLine("limInf? ");
            limInf = int.Parse(Console.ReadLine());
            Console.WriteLine("LimSup? ");
            limSup = int.Parse(Console.ReadLine());
            Console.WriteLine("numTent? ");
            numTent = int.Parse(Console.ReadLine());

            Jogo j = new Jogo(limSup, limInf, numTent);

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("HEY! " + (char)1 + " " + (char)3 + " " + (char)2);
            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.Beep(i*1000, 250);
            }

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
