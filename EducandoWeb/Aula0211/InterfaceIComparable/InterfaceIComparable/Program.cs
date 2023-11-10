using InterfaceIComparable.Entities;

string path = @"C:\Users\Igor\Desktop\Igor\Repositorios\Csharp_Curso\EducandoWeb\Arquivos para Testes\aula0211.csv";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();
        while (!sr.EndOfStream)
        {
            list.Add(new Employee(sr.ReadLine()));
        }
        // list.Sort() implementa a interface IComparable naturalmente
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}