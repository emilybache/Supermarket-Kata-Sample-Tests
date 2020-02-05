using System;
using System.ComponentModel.Design;
using Xunit;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest6
    {
        /*
         * Pricing rules:
         *
         * SKU  price  offers
         * A 	50 	   3 for 130
         * B 	30     2 for 45
         * C 	20
         * D 	15
         */
        public int Price(string goods)
        {
            var checkout = new CheckOut(RULES);
            foreach (var sku in goods)
            {
                checkout.scan(sku);
            }

            return checkout.total();
        }

        [Fact]
        public void Totals()
        {
            Assert.Equal(0, Price(""));
            Assert.Equal(50, Price("A"));
            Assert.Equal(80, Price("AB"));
            Assert.Equal(115, Price("CDBA"));
            
            Assert.Equal(100, Price("AA"));
            Assert.Equal(130, Price("AAA"));
            Assert.Equal(180, Price("AAAA"));
            Assert.Equal(230, Price("AAAAA"));
            Assert.Equal(260, Price("AAAAAA"));
            
            Assert.Equal(160, Price("AAAB"));
            Assert.Equal(175, Price("AAABB"));
            Assert.Equal(190, Price("AAABBD"));
            Assert.Equal(190, Price("DABABA"));
        }
    }
}