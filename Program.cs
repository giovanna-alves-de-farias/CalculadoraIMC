using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o seu nome");
            string nome = Console.ReadLine();
 
            Console.WriteLine("Insira a sua altura");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira o seu peso em Kg. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = (peso/(altura*altura));

            Console.WriteLine("{0} A sua altura é {1} e o seu peso é {2}", nome, altura, peso);
            Console.WriteLine("O seu IMC é {0}", imc);
        }
    }
}
