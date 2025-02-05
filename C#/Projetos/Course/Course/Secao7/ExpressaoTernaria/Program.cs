using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Secao7.ExpressaoTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            //SINTAXE DA ESTRUTURA OPCIONAL DO IF-ELSE
            //( condicao ) ? valor_se_verdadeiro : valor_se_falso 

            //( 2 > 4) ? 50 : 80 -> 80
            //( 10 != 3 ) ? Maria : Alex -> Maria

            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }

            double preco1 = 34.5;
            double desconto1 = (preco1 < 20.0) ? preco1 * 0.1 : preco1 * 0.05;

        }
    }
}
