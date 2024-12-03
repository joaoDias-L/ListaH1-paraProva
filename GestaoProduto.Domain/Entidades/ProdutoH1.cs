namespace GestaoProduto.Domain.Entidades
{
    public class ProdutoH1 : EntidadeBase
    {
        public ProdutoH1()
        {
            
        }

        public string nome { get; set; }
        public string descricao { get; set; }
        public string codigoBarra { get; set; }
        public int valor { get; set; }
        public int estoque { get; set; }

        public ProdutoH1( string NOME, string DESCRICAO, string CODIGOBARRA, int VALOR, int ESTOQUE)
        {
            nome = NOME;
            descricao = DESCRICAO;
            codigoBarra = CODIGOBARRA;
            valor = VALOR;
            estoque = ESTOQUE;
        }
    }
}
