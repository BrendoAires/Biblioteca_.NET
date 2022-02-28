using System.Collections.Generic;

namespace DIO.Biblioteca.Interface
{
    public interface IRepositorio<T>
    {
         List<T> Lista();
         T RetornaPorId(int id);
         void Insere(T endidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();

    }
}