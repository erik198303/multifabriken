using System;

namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
        //meny
        while (true)
            {
                Console.Clear();
                System.Console.WriteLine("[1] Skapa beställning:");
                System.Console.WriteLine("[2] Ändra beställning:"); 
                System.Console.WriteLine("[3] Skicka offert.");
                System.Console.WriteLine("[4] Avsluta.");
                System.Console.Write("Välj: ");

                string meny = Console.ReadLine();
                string menyProducts = "";

                switch (meny)
                {

                    case "1":
                        Console.Clear();
                        System.Console.WriteLine("[1] Bil");
                        System.Console.WriteLine("[2] Godis");
                        System.Console.WriteLine("[3] Rör");
                        System.Console.WriteLine("[4] Havremjölk");
                        System.Console.Write("Välj produkt: ");

                        menyProducts = Console.ReadLine();
                        switch (menyProducts)
                        {
                            case "1":
                                Console.Clear();
                        
                                break;

                            case "2":
                                Console.Clear();
                               
                                break;

                            case "3":
                                Console.Clear();
                             
                                break;

                            case "4":
                                Console.Clear();
                                
                                break;
                        }
                        break;

                    case "2":
                    break;  

                    case "3":
                    break; 

                    case "4":
                    return;
                    }
                  
                }
          
        }
    }
}
