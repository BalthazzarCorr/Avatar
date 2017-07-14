
using System.Collections.Generic;

public class Nations
{
   private List<EarthBender> earthBenders;
   private List<AirBender> airBenders;
   private List<WaterBender> waterBenders;
   private List<FireBender> fireBenders;


   public Nations( List<AirBender> airBenders,  List<FireBender> fireBenders, List<EarthBender> earthBenders,  List<WaterBender> waterBenders)
   {
      
      this.EarthBenders = earthBenders;
      this.AirBenders = airBenders;
      this.WaterBenders = waterBenders;
      this.FireBenders = fireBenders;
   }

   public List<EarthBender> EarthBenders { get; private set; }
   public List<AirBender> AirBenders { get; private set; }

   public List<WaterBender> WaterBenders { get; private set; }
   public List<FireBender> FireBenders { get; private set; }
}

