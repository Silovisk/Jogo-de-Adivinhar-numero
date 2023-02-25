using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_advinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tentativas = 5;
            Random random = new();
            int numero_sorteado = random.Next(1, 101);

            Console.WriteLine("Foi gerado um numero aleatorio entre 1 a 100 você tem 5 tentativas para acertar: ");

            for (int i = 1; i <= tentativas; i++)
            {
                Console.WriteLine(i + "° Chance ");
                Console.WriteLine("Informe um numero: ");
                int palpite = Convert.ToInt32(Console.ReadLine());

                if (palpite == numero_sorteado)
                {
                    Console.WriteLine("Parabens você acertou!!");
                }
                else if (palpite > numero_sorteado)
                {
                    Console.WriteLine("O numero sorteado e menor");
                }
                else if (palpite < numero_sorteado)
                {
                    Console.WriteLine("O numero sorteado e maior");
                }
                else 
                {
                    Console.WriteLine("Invalido!");
                }
            }
            Console.WriteLine("Acabou suas chances o numero sorteado foi " + numero_sorteado);
        }
    }
}
