using poo_elevador;

Elevador Ev = new Elevador();

 for (int i = 0; i < Ev.Capacidade; i++)
       {
            Console.WriteLine(Ev.Pessoas[i]);
            i++;

        }


    Console.WriteLine($"Bem-vindo ao sistema do elevador");
    Console.WriteLine($"deseja entrar?");
    string opcao =Console.ReadLine();
    
    switch (opcao)
    {
        case "sim":
        Ev.Entrar();
        break;
        default:
            break;
    }
    
    
    
