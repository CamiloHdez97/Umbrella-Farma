using Dominio.Interfaces.Pager;

namespace API.Helpers;
public class Pager<T>:IPager<T> where T : class{
    public IParam Conf { get; }
    public int Total { get;  set; }
    public List<T> Registers { get; private set; }
    public Pager(List<T> registers, int? total, IParam conf){
        Registers = registers;
        Total = total?? 0;
        Conf = conf;
    }

    public int TotalPages{
        get=> (int)Math.Ceiling(Total / (double)Conf.PageSize);
        set => Total = value;
    }
    
    public bool HasPreviousPage => Conf.PageIndex > 1;

    public bool HasNextPage=> Conf.PageIndex < TotalPages;
}
