using System;

namespace Exercicio_voto_Aula_23_11_2020
{
    class Program
    {
        static void Main(string[] args)

        //Ler o ano atual e o ano de nascimento de uma pessoa. Escrever uma mensagem que diga se
        //ela poderá ou não votar este ano (não é necessário considerar o mês em que a pessoa nasceu).

        {
            Console.WriteLine("EXERCÍCIO 1");

            //ENTRADA

            Console.WriteLine("Digie o ano atual");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.Write("Digite o seu ano de nascimento: ");
            int anoNascimento = int.Parse(Console.ReadLine());

            //PROCESSAMENTO

            int idade = anoAtual - anoNascimento;

            Console.WriteLine($"Sua idade é de:{idade} anos.");

            //SAÍDA

            if (idade >= 16){
                Console.WriteLine("Você pode votar.");
            }

            else{
                Console.WriteLine("Você não pode votar ainda.");
            }

        }
    }
}
