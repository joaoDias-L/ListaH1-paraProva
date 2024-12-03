using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GestaoProduto.Domain.Entidades;

namespace GestaoProduto.Data.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<ProdutoH1> Produto { get; set; } // Intermedio entre o banco e a aplicação

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
 
            // Recebe configurações (como o tipo de banco de dados e string de conexão) através do DbContextOptions.
            // Passa essas configurações para a classe base (DbContext) para configurar automaticamente a conexão com o banco 
            // Sem ele, precisariamos configurar a conexao manualmente
        }
    }
}
