using System;

class Program
{
    static void Main(string[] args)
    {
        IPagina pagina = new Base();
        pagina = new ArialDecorator(pagina);
        pagina = new BlueDecorator(pagina);

        String computedColor = pagina.Color();
        String computedTipo = pagina.Tipografia();

        Console.WriteLine(computedColor);
        Console.WriteLine(computedTipo);
    }
}
