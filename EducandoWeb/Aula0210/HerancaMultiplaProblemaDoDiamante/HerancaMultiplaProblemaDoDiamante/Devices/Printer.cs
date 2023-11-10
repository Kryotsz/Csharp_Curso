namespace HerancaMultiplaProblemaDoDiamante.Devices
{
    // vai ser subclasse de Device, mas também vai implementar IPrinter
    internal class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Printer processing: {document}");
        }

        // método implementado da interface Printer
        public void Print(string document)
        {
            Console.WriteLine($"Printer print: {document}");
        }
    }
}
