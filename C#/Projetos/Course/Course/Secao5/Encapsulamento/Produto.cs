using System.Globalization;
namespace Course.Secao5.Encapsulamento
{
    class Produto
    {
        //MUDA DE PUBLIC PARA PRIVADO E ALTERA AS VARIVEIS PARA _[NOME DA VARIAVEL]
        private string _nome;
        private double _preco;
        private int _quantidade;

        //CONSTRUTOR COM PARAMETROS
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        //TORNA IMPOSSIVEL ALTERAR O VALOR DAS DO "_nome" E "_preco" PORQUE NAO EXISTE O METODO SET DE "SetPreco"
        //IMPLEMENTACAO DOS METODOS GET E SET
        //GET
        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }

        //SET
        public void SetNome(string nome)
        {
            _nome = nome;
        }
        
        //CONSTRUTOR COM 2 PARAMETROS
        public Produto(string nome, double preco) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 0; //Por padrao o valor é zero, se nao colocar algum valor
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}