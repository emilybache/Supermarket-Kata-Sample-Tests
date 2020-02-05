using System.Collections.Generic;
using NHamcrest;
using Xunit;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest5
    {
        const int applePrice = 10;
        const int bananaPrice = 15;
        Till till;
 
        public SupermarketTest5() {
            till = new Till(
                new Dictionary<string, int> {
                {"Apple", applePrice},
                {"Banana", bananaPrice}
            });
        }
        
        [Fact]
        public void scanning_different_multiple_items_gives_sum_of_prices() {
            till.Scan("Banana");
            till.Scan("Apple");
 
            Assert.That(till.Total, 
                Is.EqualTo(bananaPrice + applePrice)
                );
        }
    }
}