using System;

namespace multifabriken
{
    class Oatmeal : Product
    {
        public int fatContent;
        public override void Config() 
        {
			BaseConfigLiter();
			
            Console.Write("Ange fetthalt(2% - 11% ): ");
            fatContent = Convert.ToInt32(Console.ReadLine()); 
		
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[Havremjölk] Mängd havremjölk: {0}liter med fetthalt: {1}%",liter,fatContent);
        }
    }
}
