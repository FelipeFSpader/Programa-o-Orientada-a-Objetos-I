using System;
namespace SistemaLoja;

    public class Funcionario : Pessoa
    {
        private double salario; 
        protected string cargo; 

        public Funcionario(string nome, string cpf, double salario, string cargo):base(cpf, nome)
        {
            if (salario < 0)
                throw new ArgumentException("Salário não pode ser negativo");
            this.salario=salario;
            this.cargo=cargo;
            
        } 

        public double Salario
        {
            get=>salario;
            set{
                if(value<0) //valor do atributo que está sendo passado
                    throw new ArgumentException("Salário não pode ser menor que zero");
            }
        }
        public void AjustarSalario(double percentual)
        {
            salario+=salario*percentual/100;   
        }

        public override void Apresentar()
        {
            base.Apresentar();
            Console.WriteLine("");
        }
    }