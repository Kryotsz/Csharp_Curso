namespace ExercicioFixacaoConjuntos.Entities
{
    // object student
    internal class Student
    {
        // property Id (unique for each student)
        public int Id { get; set; }

        // constructor
        public Student(int id)
        {
            Id = id;
        }

        // override the GetHashCode method to return the HashCode of the Id
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        // override the Equals method to compare students Id
        public override bool Equals(object? obj)
        {
            // verify if the object isn't a student
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Id.Equals(other.Id);
        }
    }
}
