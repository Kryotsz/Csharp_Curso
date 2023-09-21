int n = int.Parse(Console.ReadLine());
// variavel de controle de números negativos
int negativeNumbers = 0;
// instancia a matriz de inteiros de ordem 'n'
int[,] mat = new int[n, n];
// loop para popular a matriz
for (int l = 0; l < n; l++)
{
    // vetor que terá os valores da linha
    string[] linha = Console.ReadLine().Split(' ');
    for (int c = 0; c < n; c++)
    {
        // popula a linha e a coluna atual da matriz com o valor atual do vetor 'linha'
        mat[l,c] = int.Parse(linha[c]);

        // verifica se o valor atual é negativo
        if (mat[l,c] < 0)
        {
            // aumenta a variavel
            negativeNumbers++;
        }
    }
}
// instancia um novo vetor que terá os valores da diagonal principal
int[] mainDiagonal = new int[3];
// loop para preencher o vetor
for (int i = 0; i < n; i++)
{
    // vetor na posição atual recebe o valor da matriz na linha atual e coluna atual
    mainDiagonal[i] = mat[i,i];
}

// imprime na tela os valores da diagonal principal
Console.WriteLine("Main diagonal:");
Console.WriteLine($"{mainDiagonal[0]} {mainDiagonal[1]} {mainDiagonal[2]}");
// imprime na tela a quantidade de números negativos da matriz
Console.WriteLine("Negative numbers = " + negativeNumbers);

//for (int l = 0; l < n; l++)
//{
//    for (int c = 0; c < n; c++)
//    {
//        Console.Write(mat[l,c] + " ");
//    }
//    Console.WriteLine();
//}
