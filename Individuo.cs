public class Individuo // Uso de propriedades
{ 

    public String Nome { get; set; }
    public double Altura { get; set; }
    public double Peso { get; set; }
    public double Imc { get => Peso / (Altura * Altura); }

    public Individuo(String nome, double altura, double peso)
    {
        Nome = nome;
        Altura = altura;
        Peso = peso;
    }

    public String ClassificacaoImc()
    {
        if(Imc <= 18.5)
            return "Abaixo do Peso";

        if(Imc >= 18.5 && Imc <= 24.9)
            return "Peso Normal";

        if(Imc >= 25 && Imc <= 29.9)
            return "Sobrepeso";

        if(Imc >= 30 && Imc <= 34.9)
            return "Obesidade Grau I";

        if(Imc >= 35 && Imc <= 39.9)
            return "Obesidade Grau II";

        else if (Imc >= 40)
            return "Obesidade Grau III ou Mórbida";

        return "";
    }
}