using System;
using System.Collections.Generic;

namespace multifabriken
{
    class Product
    {
      public string amount;
      public int counter;

		public virtual void Config()
        {
			BaseConfig();
		}

		protected void BaseConfig()
        {
			Console.WriteLine("Skriv in antal:");
			amount = Console.ReadLine();
		}

		public virtual void PrintReceipt() 
        {
			Console.WriteLine("[KVITTO] " + amount + " st produkter");
        }
      
    }
}
