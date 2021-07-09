using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Contratos
{
    public interface IBaseRepositorio<TEntity> : IDisposable where TEntity: class
    {
        void Adicionar(TEntity entity);

        void Atualizar(TEntity entity);

        IEnumerable<TEntity> ObterTodos();

        TEntity ObterPorID(int id);

        void Remover(TEntity entity);

    }
}
