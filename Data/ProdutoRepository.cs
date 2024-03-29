using System.Collections.Generic;
using System.Linq;

namespace RCN.API.Data
{
    public class ProdutoRepository : IProdutoRepository
    {   
        private readonly ProdutoContexto contexto;

        public ProdutoRepository(ProdutoContexto contexto)
        {
            this.contexto = contexto;
        }
        public void Editar(Produto produto)
        {
            contexto.Produtos.Update(produto);
            contexto.SaveChanges();
        }

        public void Excluir(Produto produto)
        {
            contexto.Produtos.Remove(produto);
             contexto.SaveChanges();
        }

        public void Inserir(Produto produto)
        {
            contexto.Produtos.Add(produto);
             contexto.SaveChanges();
        }

        public Produto Obter(int id)
        {
           return contexto.Produtos.Find(id);
        }

        public IEnumerable<Produto> Obter()
        {
            return contexto.Produtos.ToList();
        }
    }
}