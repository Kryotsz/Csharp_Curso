string[] horas = Console.ReadLine().Split(' ');

int horaInicial = int.Parse(horas[0]);
int horaFinal = int.Parse(horas[1]);

int duracao;

if (horaFinal > horaInicial)
{
    duracao = horaFinal - horaInicial;
}
else
{
    duracao = 24 - horaInicial + horaFinal;
}

Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");