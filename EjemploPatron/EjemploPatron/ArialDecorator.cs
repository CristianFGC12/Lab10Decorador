public class ArialDecorator : PaginaDecorator
{
    public ArialDecorator(IPagina pagina) : base(pagina) { }

    public override String Tipografia()
    {
        return "Arial";
    }
}
