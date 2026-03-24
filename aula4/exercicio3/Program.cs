string escolha;
Console.WriteLine("escolha uma classe: \n1 - Guerreira \n2 - Mago \n3 - Arqueira");
escolha = Console.ReadLine();
switch (escolha)
{
    case "1":
        Console.WriteLine("Você escolheu a classe Guerreira");
        Console.WriteLine("Suas habilidades são: Ataque Pesado, Defesa Total");
        break;
    case "2":
        Console.WriteLine("Você escolheu a classe Mago");
        Console.WriteLine("Suas habilidades são: Bola de Fogo, Teletransporte");
        break;
    case "3":
        Console.WriteLine("Você escolheu a classe Arqueira");
        Console.WriteLine("Suas habilidades são: Tiro Certeiro, Furtividade");
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;
}

