﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
   private List<Bender> benders;
   private List<Monument> monuments;

   public Nation()
   {
      this.benders = new List<Bender>();
      this.monuments = new List<Monument>();
   }

   public double GetTotalPower()
   {
      int monumentsIncresePercentage = this.monuments.Sum(m => m.GetAffinity());
      double totalBendersPower = this.benders.Sum(b => b.GetPower());
      double totalPowerIncrese = totalBendersPower / 100 * monumentsIncresePercentage;

      return totalBendersPower+totalPowerIncrese;
   }

   public void AddBender(Bender currentBender)=>this.benders.Add(currentBender);

   public void AddMonument(Monument currentMonument) => this.monuments.Add(currentMonument);

   public override string ToString()
   {
      StringBuilder result = new StringBuilder();
      result.Append("Benders:");
      if (this.benders.Any())
      
         result.AppendLine().AppendLine(string.Join(Environment.NewLine,
            this.benders.Select(bender => $"###{bender}")));
      
      else
      
         result.AppendLine(" None");

      result.Append("Monuments:");
      if (this.monuments.Any())
         result.AppendLine().Append(String.Join(Environment.NewLine,
            this.monuments.Select(monuments => $"###{monuments}")));
      else
         result.Append(" None");

         return result.ToString();
   }

   public void DeclareDefeat()
   {
      this.benders.Clear();
      this.monuments.Clear();
   }
}
