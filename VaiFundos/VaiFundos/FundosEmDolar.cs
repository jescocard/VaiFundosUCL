using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VaiFundos
{
    class FundosEmDolar : FundoDeInvestimento
    {
        protected double saqueComrendDesc;
        public FundosEmDolar(string nome, string sigla) : base(nome, sigla)
        {
            this.nome = nome;
            this.sigla = sigla;
        }
        public override void resgate(double valor, int codCliente,GerenciadorCliente g)
        {
            foreach (Aplicacao item in aplicacoes)
            {
                if (item.getCliente().getCod() == codCliente && item.getValorAplicacao() == valor)
                {
                    double imposto;
                    
                    imposto = ((this.calculaRendimento(item) + item.getValorAplicacao()) * 0.01);
                    saqueComrendDesc = (this.calculaRendimento(item) + item.getValorAplicacao()) - imposto;
                    Console.WriteLine("Saque Solicitado no valor de R$: {0}", item.getValorAplicacao());
                    Console.WriteLine("O Rendimento da aplicação foi de R$: {0}", this.calculaRendimento(item));
                    Console.WriteLine("O Imposto Sobre a Aplicação foi de R$: {0}", imposto);
                    Console.WriteLine("O Valor Tatal Com Rendimentos Com Descontos Foi De R$: {0}", saqueComrendDesc);
                    this.caculoNotasDolar(saqueComrendDesc);
                    aplicacoes.Remove(item);
                    return;

                }
            }
        }
        protected void caculoNotasDolar(double n)
        {
            int contNota1 = 0, contNota2 = 0, contNota5 = 0, contNota10 = 0, contNota20 = 0, contNota50 = 0, contNota100 = 0;
            int valorArredodado = 0;
            while (n != 0)
            {
                if (n >= 100)
                {
                    n -= 100;
                    contNota100++;
                }
                else if (n >= 50)
                {
                    n -= 50;
                    contNota50++;
                }
                else if (n >= 20)
                {
                    n -= 20;
                    contNota20++;
                }
                else if (n >= 10)
                {
                    n -= 10;
                    contNota10++;
                }
                else if (n >= 5)
                {
                    n -= 5;
                    contNota5++;
                }
                else if (n >= 2)
                {
                    n -= 2;
                    contNota2++;
                }
                else if(n >= 1)
                {
                    n -= 1;
                    contNota1++;
                } 
                else if (n > 0 && n < 1)
                {
                    n = 1;
                }
                

            }
            valorArredodado = (100 * contNota100) + (50 * contNota50) + (20 * contNota20) + (10 * contNota10) + (5 * contNota5) + (2 * contNota2)+(1 * contNota1);
            Console.WriteLine("Notas de 100: {0}", contNota100);
            Console.WriteLine("Notas de 50: {0}", contNota50);
            Console.WriteLine("Notas de 20: {0}", contNota20);
            Console.WriteLine("Notas de 10: {0}", contNota10);
            Console.WriteLine("Notas de 5: {0}", contNota5);
            Console.WriteLine("Notas de 2: {0}", contNota2);
            Console.WriteLine("Notas de 1: {0}", contNota1);
            Console.WriteLine("Valor Arredodado R$: {0}", valorArredodado);
        }




    }
}
