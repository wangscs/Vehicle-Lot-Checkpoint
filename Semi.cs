namespace Vehicle_Lot
{
  public class Semi : Vehicle
  {
    public Semi(string color, string make, string model, int year)
    {
      Color = color;
      Make = make;
      Model = model;
      Year = year;
    }
    public string MakeNoise()
    {
      return Honk("BOOOOOOOOOOM");
    }
    public string StartEngineSemi()
    {
      return StartEngine();
    }
  }
}
