using ArquivosFixacao.Entities;
using System.Globalization;

// leitura do caminho do arquivo (arquivo origem)
Console.Write("Enter file full path: ");
string sourceFilePath = Console.ReadLine();

try
{
    // caminho da pasta onde está o arquivo para leitura (pasta origem)
    string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
    // caminho da pasta onde vai estar o arquivo para escrita (pasta destino)
    string targetFolderPath = sourceFolderPath + @"\out";
    // caminho do arquivo para escrita (arquivo destino)
    string targetFilePath = targetFolderPath + @"\summary.csv";
    // variável de controle para criar a pasta caso não exista
    bool createFolder = true;

    // lista todas as pastas que existem no caminho informado
    IEnumerable<string> folders = Directory.EnumerateDirectories(sourceFolderPath, "*.*", SearchOption.AllDirectories);
    // percorre todas as pastas
    foreach (string s in folders)
    {
        // se a pasta for igual a pasta de destino
        if (s == targetFolderPath)
        {
            // ela não precisa ser criada pois já existe
            createFolder = false;
        }
    }

    // se a variável for verdadeira, significa que a pasta não existe, portanto deve ser criada
    if (createFolder == true)
    {
        // cria a pasta de destino
        Directory.CreateDirectory(targetFolderPath);
    }

    // faz a leitura de todas as linhas do arquivo de origem
    string[] lines = File.ReadAllLines(sourceFilePath);
    // esvazia o arquivo de destino
    File.WriteAllText(targetFilePath, String.Empty);

    // adiciona o texto no arquivo de destino
    using (StreamWriter sw = File.AppendText(targetFilePath))
    {
        // para cada linha do arquivo de origem
        foreach (string line in lines)
        {
            // se a linha NÃO for vazia
            if (line != "")
            {
                // separa a linha onde tiver vírgula
                string[] lineArray = line.Split(",");
                // separa os itens contidos na linha em variáveis diferentes
                string name = lineArray[0];
                double price = double.Parse(lineArray[1], CultureInfo.InvariantCulture);
                int quantity = int.Parse(lineArray[2]);

                // instancia um novo produto passando as variáveis como parâmetro
                Product product = new Product(name, price, quantity);
                // escreve no arquivo destino, os dados do produto
                sw.WriteLine(product);
            }
        }
    }
}
catch (IOException e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}
catch (Exception e)
{
    Console.WriteLine("An error occurred!");
    Console.WriteLine(e.Message);
}