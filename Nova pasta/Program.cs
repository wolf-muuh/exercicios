using Nova_pasta;

Elevador elevador = new Elevador();

elevador.Andar = 10;
elevador.Capacidade = 5;
elevador.qntPessoas = 0;
elevador.Inicializa(elevador.Andar, elevador.Capacidade);


string opcao3;
do
{


    Console.WriteLine(@$"
    1 - subir
    2 - descer
    3 - entrar 
    4 - sair

    0 - desligar

");
    opcao3 = Console.ReadLine();

    switch (opcao3)
    {
        case "1":
            elevador.Subir();
            Console.WriteLine($"Você está no {elevador.Andar}º andar.");

            break;
        case "2":
            elevador.Descer();
            if (elevador.Andar == 0)
            {
                Console.WriteLine($"Não da para descer mais");

            }
            else
            {
                Console.WriteLine($"Você está no {elevador.Andar}º andar.");
            }

            break;
        case "3":
            elevador.Entrar();
            if (elevador.qntPessoas == elevador.Capacidade)
            {
                Console.WriteLine($"Há {elevador.qntPessoas} no elevador. O elevador lotou!");
            }
            else if (elevador.qntPessoas <= elevador.Capacidade && elevador.qntPessoas >= 0)
            {
                Console.WriteLine($"Há {elevador.qntPessoas} no elevador.");
            }


            break;
        case "4":
            elevador.Sair();
            Console.WriteLine($"Há {elevador.qntPessoas} no elevador.");
            break;

        case "0":
            Console.WriteLine($"fim do programa");

            break;
        default:
            Console.WriteLine($"Digite uma opção válida!");
            break;
    }
} while (opcao3 != "0");