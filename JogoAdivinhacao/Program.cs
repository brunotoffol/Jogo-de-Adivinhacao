while (true)
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

        int totalDeTentativas = 0;

        Console.Write("Digite sua escolha: ");
        string entrada = Console.ReadLine();

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

        //Gerando o número aleatório a ser adivinhado
        Random geradorDeNumeros = new Random();
        int numeroSecreto = geradorDeNumeros.Next(1, 21);

    //Loop de tentativas do jogo

    for (int tentativa = 1; tentativa <= totalDeTentativas; tentativa++)
    {
        Console.Clear();
        Console.WriteLine("------------------------------");
        Console.WriteLine($"Tentaiva {tentativa} de {totalDeTentativas}");
        Console.WriteLine("------------------------------");


        //Lógica do Jogo
        Console.Write("Digite um número entre 1 e 20: ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        if (tentativa == totalDeTentativas)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Que pena! Você usou todas as suas tentativas. O número era: {numeroSecreto}");
            Console.WriteLine("------------------------------");
            break;
        }


        if (numeroDigitado == numeroSecreto)
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Parabéns! Você acertou!");
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

        Console.WriteLine("------------------------------");
        Console.WriteLine($"O número secreto era: {numeroSecreto}");
        Console.WriteLine("------------------------------");

        Console.WriteLine("Aperte Enter para continuar");
        Console.ReadLine();

    }
        Console.Write("Deseja Continuar? (S/N): ");
        string opcaoContinuar = Console.ReadLine().ToUpper();

        if (opcaoContinuar != "S")
            break;
     
    }
