public class BlueDecorator : PaginaDecorator
{
    public BlueDecorator(IPagina pagina) : base(pagina) { }

    public override string Color()
    {
        return "Azul";
    }
}