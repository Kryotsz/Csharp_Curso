namespace HerancaMultiplaProblemaDoDiamante.Devices
{
    // não pode ter múltiplas super classes
    // internal class ComboDevice : Scanner, Printer { }

    // para resolver o problema do diamante, o ComboDevice herda de Device e implementa as interfaces IScanner e IPrinter
    class ComboDevice : Device, IScanner, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine($"ComboDevice print: {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"ComboDevice processing: {document}");
        }

        public string Scan()
        {
            return "ComboDevice scan result";
        }
    }
}
