namespace Vehicle_Lot
{
  public class Vehicle
  {
    protected string Color { get; set; }
    protected string Make { get; set; }
    protected string Model { get; set; }
    protected int Year { get; set; }
    protected string Honk(string sound)
    {
      return sound;
    }
    protected string StartEngine()
    {
      return "Engine Has Started";
    }
  }
}
