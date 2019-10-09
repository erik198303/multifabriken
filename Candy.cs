using System;
using System.Collections.Generic;

namespace multifabriken
{
    class Candy : Product
    {
        public string flavor;
        public override void Config() 
        {
			BaseConfigGram();
			
			Console.WriteLine("Ange smak:");
			flavor = Console.ReadLine();
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[Godis] Antal godis i gram: {0} med smak: {1}",gram,flavor);
        }
    }
}
