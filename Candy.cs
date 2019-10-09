using System;
using System.Collections.Generic;

namespace multifabriken
{
    class Candy : Product
    {
        public string flavor;
        public override void Config() 
        {
			BaseConfig();
			
			Console.WriteLine("Ange smak:");
			flavor = Console.ReadLine();
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[KVITTO] Antal: {0} med smak {1}", amount,flavor);
        }
    }
}
