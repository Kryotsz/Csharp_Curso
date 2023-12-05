using ExercicioFixacaoConjuntos.Entities;

// char array that stores the alphabet
char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
// collection of students
HashSet<Student> students = new HashSet<Student>();

// quantity of courses input
Console.Write("How many courses do you have? ");
int n = int.Parse(Console.ReadLine());

// print an empty line
Console.WriteLine();

// loop the quantity of courses
for (int i = 0; i < n; i++)
{
    // quantity of students input for each course
    Console.Write($"How many students for course {alphabet[i]}? ");
    int studentsQuantity = int.Parse(Console.ReadLine());

    // loop the quantity of students
    for (int j = 0; j < studentsQuantity; j++)
    {
        // student ID input
        int studentId = int.Parse(Console.ReadLine());
        // add the student to the collection (if the ID doesn't exist in the collection)
        students.Add(new Student(studentId));
    }
}

// print in the console the quantity of unique students
Console.WriteLine($"Total students: {students.Count}");