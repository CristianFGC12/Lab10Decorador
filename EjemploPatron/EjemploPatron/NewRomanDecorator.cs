public class NewRomanDecorator : PaginaDecorator 
{
    public NewRomanDecorator(IPagina pagina) : base(pagina) { }

    public override string Tipografia()
    {
        return "Times New Roman";
    }
}