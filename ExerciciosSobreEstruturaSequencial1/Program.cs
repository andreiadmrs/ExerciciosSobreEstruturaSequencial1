using System;

namespace ExercicioSobreEstruturaSequencial1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
            mensagem explicativa*/

            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());

            int soma = n1 + n2;

            Console.WriteLine($"A soma dos números digitados é de {soma}.");
        }
    }
}