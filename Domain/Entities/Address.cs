using Domain.Entities.Generics;

namespace Domain.Entities;
public class Address: BaseEntityWithIntId{

  public string Neigborhood { get; set; }
  public string TypeWay  {get; set;}
  public string QuadrantPrefix {get; set;}
  public string NumberWay {get; set;}
  public string NumberVenereableWay {get; set;}
  public string NumberPlate {get; set;}
  public int PersonId { get; set; }
  public Person Person { get; set; }  
  public int CityId { get; set; }
  public City City { get; set; }  
}