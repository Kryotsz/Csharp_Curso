Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        Dictionary<string, int> candidatesVotes = new Dictionary<string, int>();

        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(",");
            string candidate = line[0];
            int votes = int.Parse(line[1]);

            if (candidatesVotes.ContainsKey(candidate))
            {
                candidatesVotes[candidate] += votes;
            }
            else
            {
                candidatesVotes[candidate] = votes;
            }
        }

        foreach (var item in candidatesVotes)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}
