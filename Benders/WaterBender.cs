public class WaterBender : Bender
{
   private float waterClarity;
   public WaterBender(string name, int power, float waterClarity) 
      : base(name, power)
   {
      this.WaterClarity = waterClarity;
   }


   public float WaterClarity
   {
      get => this.waterClarity;
      private set { this.waterClarity = value; }
   }
}
