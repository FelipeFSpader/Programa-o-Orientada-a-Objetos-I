using System;
using System.ComponentModel.DataAnnotations;

namespace ReescreverPessoa;

public class Program
{
    static void Main()
    {
        //teste de erro. tem que falhar o programa
        //Pessoa erroUm = new Pessoa("Ble", 17, "emeil.com");

        Pessoa acertoUm = new Pessoa("Luís", 20, "luis@email.com");
        
        //impossível de chamar esse método, é privado
        //acertoUm.IdentificacaoBase();
        
        acertoUm.Apresentar();
        
        acertoUm.escreveEmail("luis@hotmail.com");
        
        acertoUm.Apresentar();
    }
}

