using System;
using System.Collections.Generic;
using System.Linq;

namespace MyC_App
{
    class C_4
    {
        private const int Index = 0;

        public void StoreDictionary() 
        { 
            Dictionary<string, int> data = new Dictionary<string, int>()
            {
                {"1) Milk",25},
                {"2) Chips",50},
                {"3) Apple",30},
                {"4) Palak",40},
                {"5) Carrot",30},
                {"6) Meat",25},
                {"7) Banana",30}
            };

            foreach (KeyValuePair<string, int> item in data)
                {
                    Console.WriteLine(item.Key + " : " + item.Value);
                }

            do
            {
                

                Console.WriteLine("\nEnter the item number you want to purchase (Enter 0 to exit) : ");
                string itemNumberString = Console.ReadLine();
                int itemNumber = Convert.ToInt16(itemNumberString);

                if(itemNumber==0)
                    break;

                Console.WriteLine("\nEnter the quantity");
                string quantityString = Console.ReadLine();
                int quantity = Convert.ToInt16(quantityString);

                switch(itemNumber)
                {
                    case 1:
                        int value0 = data.ElementAt(0).Value;
                        value0 = value0 - quantity;
                        if(value0<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value0 +" items left.");
                        break;
                    
                    case 2:
                        int value1 = data.ElementAt(1).Value;
                        value1 = value1 - quantity;
                        if(value1<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value1 +" items left.");
                        break;

                    case 3:
                        int value2 = data.ElementAt(2).Value;
                        value2 = value2 - quantity;
                        if(value2<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value2 +" items left.");
                        break;

                    case 4:
                        int value3 = data.ElementAt(3).Value;
                        value3 = value3 - quantity;
                        if(value3<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value3 +" items left.");
                        break;

                    case 5:
                        int value4 = data.ElementAt(4).Value;
                        value4 = value4 - quantity;
                        if(value4<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                            Console.WriteLine("Sold! "+value4 +" items left.");
                        break;

                    case 6:
                        int value5 = data.ElementAt(5).Value;
                        value5 = value5 - quantity;
                        if(value5<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value5 +" items left.");
                        break;

                    case 7:
                        int value6 = data.ElementAt(6).Value;
                        value6 = value6 - quantity;
                        if(value6<0)
                            Console.WriteLine("Item can’t be sold! Item is out of stock.");
                        else
                            Console.WriteLine("Sold! "+value6 +" items left.");
                        break;
                }
            }while(true);

            Console.WriteLine("Thank you for purchasing");
            
        }
    }
}
