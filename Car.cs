using System;

namespace Vehicle_Lot
{
  class Car : Vehicle
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
      return honk("Beep");
    }
    
    public string StartEngineSemi()
    {
      return StartEngine();
    }
  }
}
