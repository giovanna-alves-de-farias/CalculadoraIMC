Console.WriteLine("\n Insira o seu nome");
string nome = Console.ReadLine();
 
Console.WriteLine("\n Insira a sua altura");
float altura = Convert.ToSingle(Console.ReadLine());

Console.WriteLine("\n Insira o seu peso em Kg. Ex: 67,7");
float peso = Convert.ToSingle(Console.ReadLine());

Individuo i = new Individuo(nome, altura, peso);

Console.WriteLine("\n {0} você tem a altura é {1} e o peso é {2}", nome, altura, peso);
Console.WriteLine("\n O seu IMC é {0}", i.Imc);
Console.WriteLine(i.ClassificacaoImc());
