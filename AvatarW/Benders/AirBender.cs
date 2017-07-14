public class AirBender : Bender
{
   private double aerialIntegirty;

   public AirBender(string name, int power, double aerialIntegirty)
      : base(name, power)
   {
      this.aerialIntegirty = aerialIntegirty;
      
   }


   public override double GetPower() => this.aerialIntegirty * this.Power;

   public override string ToString() => $"{base.ToString()}, Aerial Integrity: {this.aerialIntegirty:f2}";
}



