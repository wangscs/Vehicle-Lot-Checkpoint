namespace Vehicle_Lot
{
  public class Car : Vehicle
  {
    public Car(string color, string make, string model, int year)
    {
      Color = color;
      Make = make;
      Model = model;
      Year = year;
    }
    public string MakeNoise()
    {
      return Honk("Beep");
    }
    public string StartEngineSemi()
    {
      return StartEngine();
    }
  }
}
