using System;

namespace Vehicle_Lot
{
  internal class Vehicle
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
