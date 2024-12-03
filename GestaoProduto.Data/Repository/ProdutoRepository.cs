using GestaoProduto.Data.Context;
using GestaoProduto.Domain.Entidades;
using GestaoProduto.Domain.Interfaces;
using GestaoProduto.Data.Context;

namespace GestaoProduto.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {

        private readonly AppDBContext _context;

        public ProdutoRepository(AppDBContext context)
        {
            _context = context;
        }

        public void Adcionar(ProdutoH1 produto)
        {
            _context.Produto.Add(produto);
            _context.SaveChanges();
        }

        public void AtualizarEstoque(ProdutoH1 produto)
        {
            _context.Produto.Update(produto);  // Marca a entidade como modificada
            _context.SaveChanges();  // Persiste a alteração no banco
        }


        public ProdutoH1? GetByCodigoBarra(string codigo)
        {
            return _context.Produto.Where(a => a.codigoBarra == codigo).FirstOrDefault();
        }

        public ProdutoH1? GetByNome(string nomeProduto)
        {
            return _context.Produto.Where(a => a.nome == nomeProduto).FirstOrDefault();
           
        }

        public ProdutoH1? GetProdutoByID(int produtoID)
        {
            return _context.Produto.Where(a => a.id == produtoID).FirstOrDefault();
        }

        public void  BaixarEstoque(int produtoID, int quantidade)
        {
            ProdutoH1? produto = GetProdutoByID(produtoID);

            if (produto is null)
                throw new KeyNotFoundException("Produto não encontrado.");

            if (produto.estoque < quantidade)
                throw new InvalidOperationException("Estoque insuficiente.");

            produto.estoque -= quantidade;
            _context.SaveChanges(); 
        }

        public ProdutoH1? GetProdutoByCodigoBarras(string codBarras)
        {
            return _context.Produto.Where(a => a.codigoBarra == codBarras).FirstOrDefault();
        }
    }
}
