using System;

namespace multifabriken
{
    class Pipe : Product
    {
         public string material;
        public override void Config() 
        {
			BaseConfig();
			
			Console.Write("Ange material på rör:");
			material = Console.ReadLine();
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[KVITTO] Antal rör: {0} av material {1},",amount,material);
        }
       
    }
}
