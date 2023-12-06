namespace System
{
    static class StringExtensions
    {
        public static string Cut(this string thisObj, int position)
        {
            // se o tamanho for menor ou igual a posição recebida
            if (thisObj.Length <= position)
            {
                // retorna a própria string
                return thisObj;
            }
            else
            {
                // retorna a string com o texto cortado a partir da posição especificada
                return thisObj.Substring(0, position) + "...";
            }
        }
    }
}
