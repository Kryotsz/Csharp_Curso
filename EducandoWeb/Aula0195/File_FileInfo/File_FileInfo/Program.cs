// o @ é para não precisar digitar duas barras
string sourcePath = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file1.txt";
string targetPath = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file2.txt";

try
{
    FileInfo fileInfo = new FileInfo(sourcePath);
    fileInfo.CopyTo(targetPath);
    string[] lines = File.ReadAllLines(sourcePath);
    foreach (string line in lines)
    {
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}