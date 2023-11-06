namespace ex01
{
    internal class ConversorDeMoeda
    {
        public static decimal Iof = 0.06M;

        public static decimal Conversao(decimal cotacao, decimal valor)
        {
            return valor * cotacao + (valor * cotacao) * Iof;
        }
    }
}
