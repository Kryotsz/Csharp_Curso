string path = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file1.txt";

// informa o caracter de separação do caminho
Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
// informa o caracter de separação entre caminhos (paths) diferentes
Console.WriteLine("PathSeparator: " + Path.PathSeparator);
// informa o CAMINHO da PASTA
Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
// informa o NOME do ARQUIVO COM EXTENSÃO
Console.WriteLine("GetFileName: " + Path.GetFileName(path));
// informa somente a EXTENSÃO do ARQUIVO
Console.WriteLine("GetExtension: " + Path.GetExtension(path));
// informa somente o NOME do ARQUIVO
Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
// informa o CAMINHO COMPLETO do ARQUIVO COM EXTENSÃO
Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
// informa o CAMINHO da PASTA TEMPORÁRIA do sistema
Console.WriteLine("GetTempPath: " + Path.GetTempPath());