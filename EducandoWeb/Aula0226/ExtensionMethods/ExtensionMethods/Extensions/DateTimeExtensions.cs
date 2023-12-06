using System.Globalization;

// namespace ExtensionMethods.Extensions, foi alterado para System, para facilitar a utilização, já que o DateTime já pertence ao namespace System
namespace System
{
    static class DateTimeExtensions
    {
        // lá no Program.cs está assim: dt.ElapsedTime()
        // esse this se refere ao "dt", ele pega a própria variável que chamou o método e transforma em objeto
        public static string ElapsedTime(this DateTime thisObj)
        {
            // calcula o tempo decorrido de agora até o tempo informado no objeto
            TimeSpan duration = DateTime.Now.Subtract(thisObj);

            // se a duração em horas for menor que 24 horas
            if (duration.TotalHours < 24.0)
            {
                // retorna a duração em horas
                return duration.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " hours";
            }
            else if (duration.TotalDays < 365.0)
            {
                // retorna a duração em dias
                return duration.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " days";
            }
            else
            {
                // retorna a duração em anos
                return (duration.TotalDays / 365).ToString("F1", CultureInfo.InvariantCulture);
            }
        }
    }
}
