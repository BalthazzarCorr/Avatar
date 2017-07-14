public class EarthBender : Bender
{
   private float groundSaturation;

   public EarthBender(string name, int power)
      : base(name, power)
   {
   }


   public float GroundSaturation { get; private set; }
}
