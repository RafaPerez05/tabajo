using JogadorFutebol;
using EquipeEsports;
using Produtos;
using Professores;

namespace TABAJOED{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct JOGADOR
            Jogador jogador1 = new();
            
            jogador1.nome = "Yan";
            jogador1.cv = 1;
            jogador1.ca = 0;
            jogador1.clube = "Santos";

            jogador1.aumentaCA(2);
            jogador1.aumentaCV(2);
            Console.WriteLine(jogador1.imprimir());
            Console.WriteLine(jogador1.verificaClube());

            //Struct EquipeEsports  
            Equipe equipe1 = new();
            equipe1.nome = "PAIN";
            equipe1.campVencido = 1;
            equipe1.valorPremiacao = 10000;
            equipe1.anoEstrea = 2016;

            equipe1.RegistaCampeonatosVencidos(2);
            Console.WriteLine(equipe1.imprimir());
            Console.WriteLine(equipe1.verificaAnoEstrea());

            //Struct Produtos  
            Produto produto1 = new();
            produto1.nome = "Arroz";
            produto1.qtd = 10;
            produto1.valor = 200;
            produto1.desconto = 10;

            Console.WriteLine(produto1.imprimir());
            Console.WriteLine(produto1.verificarQuantidadeEmEstoque());
            Console.WriteLine(produto1.aplicarCupomDescontoValor());


            //Struct Professor  
            Professor professor1 = new();
            professor1.nome = "Gilmar";
            professor1.salario = 10000;
            professor1.faltas = 20;
            professor1.cargaH = 10;

            Console.WriteLine(professor1.imprimir());
            Console.WriteLine(professor1.reajusteSalarialEmValor(200));
            Console.WriteLine(professor1.reajusteSalarialEmPorcentagem(20));
            Console.WriteLine(professor1.descontoSalarialPorFaltaEmValor());
            Console.WriteLine(professor1.descontoSalarialPorFaltaEmPorcentagem(10));
            Console.WriteLine(professor1.aumentarCargaHorariaDeTrabalho(5));



        }
    }
}
