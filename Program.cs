using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Insira o seu nome");
            string nome = Console.ReadLine();
 
            Console.WriteLine("\n Insira a sua altura");
            float altura = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("\n Insira o seu peso em Kg. Ex: 67,7");
            float peso = Convert.ToSingle(Console.ReadLine());

            double imc = (peso/(altura*altura));

            Console.WriteLine("\n {0} A sua altura é {1} e o seu peso é {2}", nome, altura, peso);
            Console.WriteLine("\n O seu IMC é {0}", imc);

            // Informações da Tabela de IMC
            if(imc < 17){
                Console.WriteLine("Você está muito abaixo do peso");
            }else if((imc > 17) && (imc < 18.5)){
                Console.WriteLine("Você está abaixo do peso");
            }else if(imc > 18.5 && imc < 25){
                Console.WriteLine("Você está com o peso normal");
            }else if((imc > 25) && (imc < 30)){
                Console.WriteLine("Você está acima do peso");
            }else if((imc > 30) && (imc < 35)){
                Console.WriteLine("Você está no grau de obesidade I");
            }else if((imc > 35) && (imc < 40)){
                Console.WriteLine("Você está no grau de Obesidade II, ou seja, severa");
            }else  if (imc > 40){
                Console.WriteLine("Obesidade Grau III, ou seja, mórbida");
            }
        }
    }
}
