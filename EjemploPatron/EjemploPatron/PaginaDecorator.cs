public abstract class PaginaDecorator : IPagina
{
    protected IPagina pagina;

    public PaginaDecorator(IPagina pagina)
    {
        this.pagina = pagina;
    }

    public virtual String Color()
    {
        return pagina.Color();
    }

    public virtual String Tipografia() 
    { 
        return pagina.Tipografia(); 
    }
}