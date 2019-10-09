using System;

namespace multifabriken
{
    class Oatmeal : Product
    {
         public int fatContent;
        public override void Config() 
        {
			BaseConfig();
			
            Console.Write("Ange fetthalt(2% - 11% ): ");
            fatContent = Convert.ToInt32(Console.ReadLine()); 
		
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[KVITTO] Fetthalt på havemjölk: {0} och mängd {1} liter.",fatContent,amount);
        }
    }
}
