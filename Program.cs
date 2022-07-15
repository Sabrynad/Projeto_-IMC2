using System;

namespace Projeto_IMC_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            string idade = Console.ReadLine();

            Console.WriteLine("Insira seu peso: ");
            float peso = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a sua altura; ");
            float altura = (float)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(nome);
            Console.WriteLine($"Sua idade é:  {idade}");
            Console.WriteLine("Seu peso é: " + peso);
            Console.WriteLine($"Sua altura é: {altura}");

            float imc = peso / (altura * altura);


            if (imc < 18)
            {
                Console.WriteLine("Você está abaixo do peso");
            }
            else if (imc < 25)
            {
                Console.WriteLine("Você está na média de peso");
            }
            else if (imc < 30)
            {
                Console.WriteLine("Você está no sobrepeso");
            }
            else if (imc > 40)
            {
                Console.WriteLine("Você está em estado de obesidade");
            }
        }
    }
}
