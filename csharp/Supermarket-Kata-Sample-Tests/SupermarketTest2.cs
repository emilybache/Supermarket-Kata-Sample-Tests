using System;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest2
    {
        public static void Main()
        {
            // Test to check if the price
            // calculation is correct or not.
            // For 4quantities of A, 1 quantity
            // of item B and 4 quantities of item C
            // the total price should be 320.0.
            // Test to check this.
            var ck = new Checkout();
            ck.addItem("A", 4);
            ck.addItem("B", 1);
            ck.addItem("C", 4);
            if (ck.calculateTotalPrice(
                    ck.itemsListMap) == 320.0) 
                Console.Write("Passed");
            else 
                Console.Write("Failed");

            // For 1 quantity of item B
            // and 4 quantities of item C
            // the total price should be 110.0.
            // Test to check this.
            try
            {
                ck.removeItem("A", 4);
            }
            catch (Exception e)
            {
                // TODO Auto-generated catch block
                Console.WriteLine(e.ToString());
            }

            if (ck.calculateTotalPrice(
                    ck.itemsListMap) == 110.0) 
                Console.Write("Passed");
            else 
                Console.Write("Failed");
        }
    }
}