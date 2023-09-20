namespace Dominio.Interfaces.Pager;
public interface IParam{
    int PageSize {get; set;}
    int PageIndex {get; set;}
    string Search {get; set;}
}
