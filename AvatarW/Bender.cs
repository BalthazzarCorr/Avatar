public abstract class Bender
{
   
   protected Bender(string name, int power)
   {
      this.Name = name;
      this.Power = power;
   }


   public int Power { get; private set; }

   public string Name { get; private set; }

   public abstract double GetPower();

   public override string ToString()
   {
      string benderType = this.GetType().Name;
      int typeEnd = benderType.IndexOf("Bender");
      benderType = benderType.Insert(typeEnd, " ");

      return $"{benderType}: {this.Name}, Power: {this.Power}";
   }
}

