namespace GenericsExemplos
{
    internal class PrintService
    {
        //atributo privado (variável interna da classe)
        private int[] _values = new int[10];
        private int _count = 0;

        // método responsável por adicionar um valor no array de valores
        public void AddValue(int value)
        {
            // se o array de valores já está cheio
            if (_count == 10)
            {
                // lança uma exceção
                throw new InvalidOperationException("PrintService is full");
            }
            // adiciona o valor no array de valores na posição count
            _values[_count] = value;
            // aumenta o contador
            _count++;
        }

        // método responsável por retornar o primeiro valor do array
        public int First()
        {
            // se o array de valores estiver vazio
            if (_count == 0)
            {
                // lança uma exceção
                throw new InvalidOperationException("PrintService is empty");
            }
            // retorna o primeiro valor do array
            return _values[0];
        }

        // método que imprime na tela os valores do array e o primeiro número
        public void Print()
        {
            Console.Write("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            if (_count  > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
