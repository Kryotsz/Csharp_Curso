string path = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes";

try
{
    // listar todas as pastas do caminho informado, contém uma máscara de busca que irá procurar qualquer nome com qualquer extensão
    IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FOLDERS:");
    foreach (string s in folders)
    {
        Console.WriteLine(s);
    }

    // listar todos os arquivos do caminho informado
    IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
    Console.WriteLine("FILES:");
    foreach (string s in files)
    {
        Console.WriteLine(s);
    }

    // criar uma pasta no caminho informado
    //Directory.CreateDirectory(path + "\\newfolder");
    Directory.CreateDirectory(path + @"\newfolder");
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}