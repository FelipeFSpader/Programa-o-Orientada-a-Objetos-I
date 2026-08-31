using System;
namespace QuartaAtividade;

public class VerificadorIdade
{
    public bool Verificador(int idade)
    {
        if (idade >= 18)
        {
            return true;    
        }
        else
        {
            return false; 
        }
    }
}
