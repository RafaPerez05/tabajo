using JogadorFutebol;

namespace TABAJOED{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            Jogador jogador1 = new();
            
            jogador1.nome = "Yan";
            jogador1.cv = 1;
            jogador1.ca = 0;
            jogador1.clube = "Santos";
//aaaaaaaa
//yanlindo
            jogador1.aumentaCA(2);
            jogador1.aumentaCV(2);
            Console.WriteLine(jogador1.imprimir());
            Console.WriteLine(jogador1.verificaClube());

        }
    }
}
