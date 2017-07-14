
public class FireBender : Bender
{
   private float heatAggression;

   public FireBender(string name, int power, float heatAggression)
   : base(name, power)
   {

      this.HeatAggression = heatAggression;
   }

   public float HeatAggression
   {
      get => this.heatAggression;
      private set { }
   }
}
