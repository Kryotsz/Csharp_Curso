namespace HerancaMultiplaProblemaDoDiamante.Devices
{
    internal class Scanner : Device, IScanner
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

        // método implementado da interface Scanner
        public string Scan()
        {
            return "Scanner scan result";
        }
    }
}
