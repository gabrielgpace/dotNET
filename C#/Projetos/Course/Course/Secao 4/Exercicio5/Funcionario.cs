﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace Course.Exercicio5
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto =+ SalarioBruto * (porcentagem/100);
            Console.WriteLine("Dados atualizados: " + Nome + ", R$ " + SalarioBruto);
        }
        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2");
        }
    }
}
