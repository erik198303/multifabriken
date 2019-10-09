using System;
using System.Collections.Generic;

namespace multifabriken
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> myCart = new List<Product>();

            

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
                                Car newCar = new Car();
                                newCar.Config();
                                myCart.Add(newCar);
                                break;

                            case "2":
                                Console.Clear();
                                Candy newCandy = new Candy();
                                newCandy.Config();
                                myCart.Add(newCandy);
                                break;

                            case "3":
                                Console.Clear();
                                Pipe newPipe =  new Pipe();
                                newPipe.Config();
                                myCart.Add(newPipe);
                                break;

                            case "4":
                                Console.Clear();
                                Oatmeal newOatmeal = new Oatmeal();
                                newOatmeal.Config();
                                myCart.Add(newOatmeal);
                                
                                break;
                        }
                        break;

                    case "2":
                     foreach(Product product in myCart)
                     {
                        product.PrintReceipt();
                     }
                     Console.ReadKey();
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
