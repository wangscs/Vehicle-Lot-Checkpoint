using System;

namespace Vehicle_Lot
{
  class Semi : Vehicle
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
