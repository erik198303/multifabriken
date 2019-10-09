using System;

namespace multifabriken
{
    class Car : Product
    {
         public string name;
         public string color;
        public override void Config() 
        {
			BaseConfig();
			
			Console.WriteLine("Ange bilmärke: ");
			name= Console.ReadLine();
            System.Console.Write("Vilken färg ska bilen ha: ");
            color = Console.ReadLine();
        }
        public override void PrintReceipt()
        {
		Console.WriteLine("[KVITTO] Antal {0}  Bilmärke: {1} och färg {2}",amount, name,color);
        }
       
    }
}
