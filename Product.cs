using System;
using System.Collections.Generic;

namespace multifabriken
{
    class Product
    {
      public string amount;
      public int liter;
      public int gram;

		public virtual void Config()
        {
			BaseConfig();
		}

		protected void BaseConfig()
        {
			Console.WriteLine("Skriv in antal:");
			amount = Console.ReadLine();
		}
        protected void BaseConfigLiter()
        {
			Console.WriteLine("Skriv in antal liter:");
			liter = Convert.ToInt32(Console.ReadLine());
		}
        protected void BaseConfigGram()
        {
			Console.WriteLine("Skriv in antal gram:");
			gram = Convert.ToInt32(Console.ReadLine());
		}

		public virtual void PrintReceipt() 
        {
			Console.WriteLine("[KVITTO] " + amount + liter +" st produkter");
        }
      
    }
}
