namespace ExercicioExemploConjuntos.Entities
{
    internal class User
    {
        public string Name { get; set; }
        public DateTime LoginDateTime { get; set; }

        public User(string name, DateTime loginDateTime)
        {
            Name = name;
            LoginDateTime = loginDateTime;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User))
            {
                return false;
            }
            User other = obj as User;
            return Name.Equals(other.Name);
        }
    }
}
