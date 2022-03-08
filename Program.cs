using StockAccountManagement;
using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/HP/Desktop/fellowShip/StockAccountManagement/Stock.json";

            FetchJasonForStock fetchJsonForStock = new FetchJasonForStock();
            Stock data = fetchJsonForStock.Read(path);

            for (int i = 0; i < data.tataGroup.Count; i++)
            {
                Console.WriteLine(data.tataGroup[i].Stockname);
                Console.WriteLine(" Number of Shares buyed: " + data.tataGroup[i].Shares);
                Console.WriteLine("Buying Price: " + data.tataGroup[i].Price);
                int dataofstock = data.tataGroup[i].Shares * data.tataGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofstock);
                Console.WriteLine("---------***--------******--------");
            }

            for (int i = 0; i < data.adaniGroup.Count; i++)
            {
                Console.WriteLine(data.adaniGroup[i].Stockname);
                Console.WriteLine(" Number of Shares buyed: " + data.adaniGroup[i].Shares);
                Console.WriteLine("Buying Price: " + data.adaniGroup[i].Price);
                int dataofshare = data.adaniGroup[i].Shares * data.adaniGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofshare);
                Console.WriteLine("---------***--------******--------");

            }

            for (int i = 0; i < data.adityaBirlaGroup.Count; i++)
            {
                Console.WriteLine(data.adityaBirlaGroup[i].Stockname);
                Console.WriteLine(" Number of Shares buyed: " + data.adityaBirlaGroup[i].Shares);
                Console.WriteLine("Buying Price: " + data.adityaBirlaGroup[i].Price);
                int dataofbirla = data.adityaBirlaGroup[0].Shares * data.adityaBirlaGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofbirla);
                Console.WriteLine("---------***--------******--------");

            }

        }
    }
}
