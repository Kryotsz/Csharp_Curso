using ExercicioFixacaoVetor;
// cria o vetor do tipo Estudante com 10 posições vazias (nulas)
Estudante[] estudantes = new Estudante[10];

// le a entrada de quantos quartos serão alugados
Console.Write("How many rooms will be rented? ");
int n = int.Parse(Console.ReadLine());

// enquanto o número de quartos for menor que 1 ou maior que 10
while (n < 1 || n > 10)
{
    // obriga o usuário a digitar um número válido
    Console.WriteLine();
    Console.WriteLine("Type a valid number!");
    Console.WriteLine();
    Console.Write("How many rooms will be rented? ");
    n = int.Parse(Console.ReadLine());
}

// loop para cadastrar os estudantes nos quartos vagos
for (int i = 0; i < n; i++)
{
    Console.WriteLine();
    Console.WriteLine($"Rent #{i+1}:");

    // entrada do nome do estudante
    Console.Write("Name: ");
    string nome = Console.ReadLine();
    // entrada do email do estudante
    Console.Write("Email: ");
    string email = Console.ReadLine();
    // entrada do quarto que o estudante deseja ocupar
    Console.Write("Room: ");
    int quarto = int.Parse(Console.ReadLine());

    // verifica se o quarto digitado está vago
    if (estudantes[quarto] == null)
    {
        // se sim, instancia um novo estudante utilizando as entradas digitadas anteriormente
        // e coloca no quarto que ele escolheu
        estudantes[quarto] = new Estudante { Name = nome, Email = email };
    }
    else
    {
        // enquanto o quarto digitado NÃO for nulo
        while (estudantes[quarto] != null)
        {
            // mostra na tela que o quarto está ocupado e obriga o usuário a escolher outro quarto vago
            Console.WriteLine();
            Console.WriteLine("Ocuppied!");
            Console.Write("Please, choose another room: ");
            quarto = int.Parse(Console.ReadLine());
        }
    }
}


Console.WriteLine();
Console.WriteLine("Busy rooms:");
// imprime na tela os quartos ocupados
for (int i = 0; i < 10; i++)
{
    // se o quarto estiver ocupado
    if (estudantes[i] != null)
    {
        // imprime na tela o número do quarto, o nome e o email do estudante
        Console.WriteLine($"{i}: {estudantes[i].Name}, {estudantes[i].Email}");
    }
}