using System.Collections.Generic;
namespace Projeto.Interfaces
{
    public interface IRepositorio<X>
    {
        
    List<X> Lista();
    X retornoporID(int id);
    void Inserir(X entidade);
    void Excluir(int id);
    void Atualiza(int id,X  entidade);
    int Proximo();

    }
}