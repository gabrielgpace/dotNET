using System.Globalization;
namespace Course.Secao5.AutoProperties
{
    class Produto
    {
        //MUDA DE PUBLIC PARA PRIVADO E ALTERA AS VARIVEIS PARA _[NOME DA VARIAVEL]
        //IMPLEMENTACAO DO AUTO PROPERTIE COM get e set NA VARIAVEL
        private string _nome;
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        

        //CONSTRUTOR COM PARAMETROS
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
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
            return Preco;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }

        //SET
        public void SetNome(string nome)
        {
            _nome = nome;
        }

        //PROPERTIES GET E SET
        public string Nome
        {
            get { return _nome; }
            set { if(value != null && value.Length > 0) 
                    _nome = value; 
            }
        }

        public double Preco_
        {
            get { return Preco; }
        }

        public int Quantidade_
        {
            get { return Quantidade; }
        }

        
        //CONSTRUTOR COM 2 PARAMETROS
        public Produto(string nome, double preco) 
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 0; //Por padrao o valor é zero, se nao colocar algum valor
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}