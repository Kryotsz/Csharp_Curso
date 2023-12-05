using ExercicioExemploConjuntos.Entities;

// variable that count the number of users that are not repeated
int uniqueUsers = 0;
// collection that will store all users
HashSet<User> users = new HashSet<User>();

// file path input
Console.Write("Enter file full path: ");
string filePath = Console.ReadLine();

// read all lines of the file and store in an string array
string[] lines = File.ReadAllLines(filePath);

// loop through each line
foreach (string line in lines)
{
    // verify if the line is not empty
    if (line != "")
    {
        // split the line into name and loginDateTime
        string[] lineArray = line.Split(' ');
        string name = lineArray[0];
        DateTime loginDateTime = DateTime.Parse(lineArray[1]);
        // create a new object User
        User u = new User(name, loginDateTime);
        // if the collection don't contain the user
        if (!users.Contains(u))
        {
            // add the user to the collection
            users.Add(u);
            // increase the variable uniqueUsers
            uniqueUsers++;
        }
    }
}

// print in the console the number of unique users
Console.Write($"Total users: {uniqueUsers}");