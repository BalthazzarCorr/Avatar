public class AirBender : Bender
{
   private float aerialIntegirty;

   public AirBender(string name, int power, float aerialIntegirty)
      : base(name, power)
   {
      this.AerialIntegrity = aerialIntegirty;
      
   }

   public float AerialIntegrity
   {
      get => this.aerialIntegirty;
      private set { }
   }

}

