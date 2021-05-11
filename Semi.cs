using System;
using Vehicle_Vehicle;

namespace Vehicle_Lot
{
  class Semi : Vehicle
  {
    // internal int wheels()
    // {
    //   var wheelCount = 18;
    //   return wheelCount;
    // }
    public string makeNoise()
    {
      return honk("BOOOOOOOOOOM");
    }
  }
}
