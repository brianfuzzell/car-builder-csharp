namespace CarBuilder.Models;

public class Order
{
   public int Id { get; set; }
   public DateTime TimeStamp { get; set; }
   public int WheelsId { get; set; }
   public int TechnologyId { get; set; }
   public int PaintId { get; set; }
   public int InteriorId { get; set; }
   public Wheels Wheels { get; set; }
   public Technology Technology { get; set; }
   public PaintColor PaintColor { get; set; }
   public Interior Interior { get; set; }
}