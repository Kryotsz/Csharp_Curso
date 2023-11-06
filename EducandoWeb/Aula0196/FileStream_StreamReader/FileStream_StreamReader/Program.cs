// stream na programação signifca Sequência de Dados

string path = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file1.txt";
// FileStream é uma stream binária
//FileStream fs = null;
// StreamReader é uma stream de caracteres que vai ser associado ao FileStream
StreamReader sr = null;

try
{
    // FileStream e StreamReader são recursos que NÃO são gerenciados pelo CLR do dotnet, portanto, devem ser fechados manualmente
    // FileStream associado a um arquivo, com a finalidade de abrir o arquivo para acesso
    //fs = new FileStream(path, FileMode.Open);
    // File.OpenText já instancia o FileStream e o StreamReader em cima dele
    sr = File.OpenText(path);
    // enquanto NÃO for o fim do stream, ou seja, ainda tiver conteúdo
    while (!sr.EndOfStream)
    {
        // le a linha e imprime na tela
        string line = sr.ReadLine();
        Console.WriteLine(line);
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred!");
    Console.WriteLine(e.Message);
}
finally
{
    // Fechamento manual, não importando se der erro ou não
    if (sr != null) sr.Close();
    //if (fs != null) fs.Close();
}