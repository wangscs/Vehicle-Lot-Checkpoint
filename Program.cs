using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Vehicle_Lot;

namespace Vehicle_Lot_Checkpoint
{
  class Program
  {
    static void Main(string[] args)
    {
      //   Vehicle car1 = new Vehicle();
      //   car1.honk();
      List<object> parkingLot = new List<object>();
      
      Semi semi1 = new Semi("yellow","Volvo","VML500", 2015);
      Car car1 = new Car("black", "Tesla", "S", 2021);
     
      semi1.MakeNoise();
    }
  }
}
