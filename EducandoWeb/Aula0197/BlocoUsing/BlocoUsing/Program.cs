string path = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\file1.txt";

try
{
    // ao final do bloco, o recurso é fechado
    //using (FileStream fs = new FileStream(path, FileMode.Open))
    //{
    //    using (StreamReader sr = new StreamReader(fs))
    //    {
    //        while (!sr.EndOfStream)
    //        {
    //            string line = sr.ReadLine();
    //            Console.WriteLine(line);
    //        }
    //    }
    //}
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {
            string line = sr.ReadLine();
            Console.WriteLine(line);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error ocurred!");
    Console.WriteLine(e.Message);
}