using System;

class Retangulo
{
  public double Largura {get; set;}
  public double Altura {get; set;}

  public Retangulo(double largura, double altura)
  {
    Largura = largura;
    Altura = altura;
  }

  public double CalcularArea()
  {
    return Largura * Altura;
  }

  public double CalcularPerimetro()
  {
    return 2 * (Largura + Altura);
  }
}

class Program
{
  static void Main(string[] args)
  {
    Console.Write("Informe a Largura do retângulo: ");
    double largura = Convert.ToDouble(Console.ReadLine());

    Console.Write("Informe a Altura do retêngulo: ");
    double altura = Convert.ToDouble(Console.ReadLine());

    Retangulo retangulo  = new Retangulo(largura, altura);

    double area = retangulo.CalcularArea();
    double perimetro = retangulo.CalcularPerimetro();

    Console.WriteLine($"Área do Retângulo: {area}");
    Console.WriteLine($"Perímetro do Retângulo: {perimetro}");
  }
}