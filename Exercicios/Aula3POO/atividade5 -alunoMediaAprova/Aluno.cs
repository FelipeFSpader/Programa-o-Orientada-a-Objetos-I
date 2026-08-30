class Aluno
{
    //propriedade simples para o nome
    public string Nome { get; set; }

    //campo privado pra guardar a nota
    private double n1 { get; set; }

    //propriedade com validação para Nota1
    public double N1
    {
        get{return n1;}
        set
        {
            if (value>=0 && value<=10)
            {
                 n1=value;
            }
        }
    }

    public double N2 { get; set; }
    public double N3 { get; set; }

    //método que calcula a média 
    //método vem com "()" no fim - igual ReadLine()
    public double Media()
    {
        return (N1 + N2 + N3) / 3;
    }

    //método pra verificar aprovação 
    public bool Aprovado()
    {
        return Media() >= 6.0;
    }

}
