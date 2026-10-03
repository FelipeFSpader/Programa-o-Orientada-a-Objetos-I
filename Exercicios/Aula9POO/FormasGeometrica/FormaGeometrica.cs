namespace FormasGeometrica;

public class FormaGeometrica
{
        public string Nome {get;set;}

        public FormaGeometrica(string nome)
        {
            Nome = nome;
        }

        public virtual double CalcularArea(double fator)
        {
            return CalcularArea() * fator;
        }
        
        public virtual double CalcularArea()
        {
            return 0;
        }
    
        public virtual void Exibir()
        {
            Console.WriteLine($"Forma: {Nome}");
        }
}

public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio) : base("Círculo")
    {
        Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * Raio * Raio;
    }
}

public class Retangulo : FormaGeometrica
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public Retangulo(double largura, double altura) : base("Retangulo")
    {
        Largura = largura;
        Altura = altura;
    }

    public Retangulo(double lado) : base("Quadrado")
    {
        Largura = lado;
        Altura = lado;
    }
    
    public override double CalcularArea()
    {
        return Largura*Altura;
    }
    
    
}

public class Triangulo : FormaGeometrica
{
    public double Basee { get; set; }
    public double Altura { get; set; }

    public Triangulo(double basee, double altura) : base("Triangulo")
    {
        Basee = basee;
        Altura = altura;
    }
    
    public override double CalcularArea()
    {
        return (Basee*Altura)/2;
    }
}
