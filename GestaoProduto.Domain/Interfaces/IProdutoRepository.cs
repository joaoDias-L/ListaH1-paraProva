using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestaoProduto.Domain.Entidades;

namespace GestaoProduto.Domain.Interfaces
{
    public interface IProdutoRepository : IRepositoryBase<ProdutoH1>
    {
        public ProdutoH1 GetProdutoByID(int id);
        public ProdutoH1 GetProdutoByCodigoBarras(string codBarras);
    }
}
