using JogoAdivinhacao;

while (true)
    {       
        
    string entrada = ExibirMenu();
        
    int totalDeTentativas = 0;   
        
    int tentativas = EscolherDificuldade();

    //Loop de tentativas do jogo
    LogicaJogo(totalDeTentativas);

    //Quebra do loop principal do jogo   
    Console.Write("Deseja Continuar? (S/N): ");
   
    string opcaoContinuar = Console.ReadLine()!.ToUpper();
    
    if (OpcaoSairEscolhida(opcaoContinuar) == false)
        break;

    static string ExibirMenu()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("------------------------------");

            Console.WriteLine("Escolha um nível de dificuldade: ");
            Console.WriteLine("------------------------------");
            Console.WriteLine("1 - Fácil - 10 tentativas");
            Console.WriteLine("2 - Médio - 5 tentativas");
            Console.WriteLine("3 - Difícil - 3 tentativas");
            Console.WriteLine("------------------------------");

            Console.Write("Digite sua escolha: ");
            string entrada = Console.ReadLine()!.ToUpper();

            return entrada;
        }                
    
    int EscolherDificuldade()
        {        

        if (entrada == "1")
        {
            totalDeTentativas = 10;
        }
        else if (entrada == "2")
        {
            totalDeTentativas = 5;
        }
        else if (entrada == "3")
        {
            totalDeTentativas = 3;
        }

        return totalDeTentativas;

    }

    static bool OpcaoSairEscolhida(string entrada)
        {
            bool opcaoSairEscolhida = entrada == "S";

            return opcaoSairEscolhida;
        }

    static void LogicaJogo(int totalDeTentativas)
    {
        for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
        {
            Console.Clear();
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Tentativa {tentativa} de {totalDeTentativas}");
            Console.WriteLine("------------------------------");
            //Lógica do Jogo
            Console.Write("Digite um número entre 1 e 20: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());

            int numeroSecreto = FuncoesJogo.GeradorNumero();

            if (numeroDigitado == numeroSecreto)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Parabéns! Você acertou!");
                Console.WriteLine("------------------------------");
                return;
            }
            if (tentativa == totalDeTentativas)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine($"Que pena! Você usou todas as suas tentativas. O número era: {numeroSecreto}");
                Console.WriteLine("------------------------------");
            }

            else if (numeroDigitado > numeroSecreto)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("O número digitado é maior que o número secreto.");
                Console.WriteLine("------------------------------");
            }
            else
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("O número digitado é menor que o número secreto.");
                Console.WriteLine("------------------------------");
            }
            Console.WriteLine("Aperte Enter para continuar");
            Console.ReadLine();
        }

        }
    }
