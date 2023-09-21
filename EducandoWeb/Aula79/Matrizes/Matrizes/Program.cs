double[,] matriz = new double[2,3];

// quantos elementos possui a matriz
Console.WriteLine(matriz.Length);
// quantas linhas(primeira dimensão) possui a matriz
Console.WriteLine(matriz.Rank);
// a primeira dimensão da matriz tem tamanho 2
Console.WriteLine(matriz.GetLength(0));
// a segunda dimensão da matriz tem tamanho 3
Console.WriteLine(matriz.GetLength(1));