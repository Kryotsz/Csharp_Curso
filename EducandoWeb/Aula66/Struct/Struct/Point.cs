namespace Struct
{
    // struct é um tipo valor, class é um tipo referência
    internal struct Point
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return "(" + X + ", " + Y + ")";
        }
    }
}
