namespace CarBuilder.Models.DTOs;

public class OrderDTO
{
   public int Id { get; set; }
   public DateTime TimeStamp { get; set; }
   public int WheelsId { get; set; }
   public int TechnologyId { get; set; }
   public int PaintId { get; set; }
   public int InteriorId { get; set; }
   public WheelsDTO Wheels { get; set; }
   public TechnologyDTO Technology { get; set; }
   public PaintColorDTO PaintColor { get; set; }
   public InteriorDTO Interior { get; set; }
   public decimal TotalCost =>
   (this.Wheels.Price) +
   (this.Technology.Price) +
   (this.PaintColor.Price) +
   (this.Interior.Price);
   public bool Fulfilled { get; set; }
}