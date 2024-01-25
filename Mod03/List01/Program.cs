namespace List01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var menu = "1 - Operações com Lista\n" +
                                   "2 - Operações com Pilha\n" +
                                   "3 - Operações com Fila\n" +
                                   "4 - Operações com Dicionário\n" +
                                   "0 - Sair\n";

            Console.WriteLine($"Módulo 03 - Lista 01\nEscolha uma das questões para executar o teste digitando o número correspondente:\n");

            bool sair = false;

            while (sair == false) 
            {
                Console.WriteLine(menu);
                
                var opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:

                        Console.WriteLine("Até logo!");
                        sair = true;
                        break;
                
                    case 1:
                        var input = new List<string>{
                          "Idiossincrasia",
                          "Ambivalente",
                          "Quimérica",
                          "Perpendicular",
                          "Efêmero",
                          "Pletora",
                          "Obnubilado",
                          "Xilografia",
                          "Quixote",
                          "Inefável"
                        };

                        var list = OperacoesLista.MaioresQueDez(input);

                        Console.Write("Lista da entrada: ");
                        OperacoesLista.MostraLista(input);
                        Console.Write("Lista da tratada com as string de 10 ou mais caracteres: ");
                        OperacoesLista.MostraLista(list);
                    
                        break;
                
                    case 2:

                        var balanceada = OperacoesPilha.VerificarExpressaoBalanceada("(2 + 1) * 80 / (7 - [√9 + { 4² *0}])");
                        var naoBalanceada = OperacoesPilha.VerificarExpressaoBalanceada("([{35 - 2} + 5*3} + 0 / 15) - [3 + 5³] * 11)");


                        Console.WriteLine($"A string \"(2 + 1) * 80 / (7 - [√9 + {{ 4² *0}}])\" é balanceada?: {balanceada}");
                        Console.WriteLine($"A string \"([{{35 - 2}} + 5*3}} + 0 / 15) - [3 + 5³] * 11)\" é balanceada?:{naoBalanceada}");

                        break;
                
                    case 3:

                        Console.WriteLine("Exemplo de Jogo da Batata Quente com a entrada de 10 jogadores utilizando fila:\n ");
                        OperacoesFila.JogoBatataQuente(10);
                    
                        break;

                    case 4:

                        var entrada = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla auctor porta velit a tincidunt. Nam efficitur iaculis placerat. Aenean lectus dui, sollicitudin id rhoncus tristique, aliquet sed quam. Phasellus blandit magna at elementum consequat. Nam vitae nunc vehicula, blandit felis a, placerat augue. Quisque bibendum a ipsum at scelerisque. Duis molestie turpis quis orci vehicula aliquam. Duis non elementum erat. Phasellus et dui odio. Nunc vitae leo sem. Curabitur nec enim id mi aliquet commodo at et sapien. Fusce sit amet nisi elit. Interdum et malesuada fames ac ante ipsum primis in faucibus. Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Duis vitae dolor at sem ultrices euismod. Morbi aliquet, felis et mattis congue, justo nunc pharetra lectus, a lobortis mauris eros et nulla. Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Maecenas sollicitudin posuere nibh malesuada suscipit. Nam a sapien ex. Donec mollis justo est, quis tempus mi pharetra at. Cras fringilla enim eu egestas scelerisque. Praesent tristique imperdiet consectetur. Donec interdum pulvinar nulla vel pharetra. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Aliquam interdum finibus mi, in tempus lorem. Cras diam magna, viverra vitae ante eget, scelerisque sodales velit. Aliquam erat volutpat. Mauris consectetur sapien mi, vel euismod quam consectetur id.";

                        Dictionary<string, int> contadorDePalavras = OperacoesDicionairo.ContarPalavras(entrada);

                        Console.WriteLine("Resposta do contador de palavras para o texto exemplo");
                        OperacoesDicionairo.MostrarContagem(contadorDePalavras);
                        break;
                    default:
                        Console.WriteLine("Valor inválido");
                        break;
                }            
            }




        }
    }
}
