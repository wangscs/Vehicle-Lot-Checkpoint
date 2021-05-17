using System.Collections.Generic;
using Vehicle_Lot;

namespace Vehicle_Lot_Checkpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Vehicle> parkingLot = new List<Vehicle>();

      Semi semi1 = new Semi("yellow", "Volvo", "VML500", 2015);
      Car car1 = new Car("black", "Tesla", "S", 2021);

      parkingLot.Add(semi1);
      parkingLot.Add(car1);
    }
  }
}
