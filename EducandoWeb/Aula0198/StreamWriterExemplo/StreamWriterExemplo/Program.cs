string sourcePath = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file1.txt";
string targetPath = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file2.txt";

try
{
    string[] lines = File.ReadAllLines(sourcePath);

    using (StreamWriter sw = File.AppendText(targetPath))
    {
        foreach (string line in lines)
        {
            sw.WriteLine(line.ToUpper());
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}