using Xunit;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest3
    {
        [Fact]
        public void items_have_a_pricingstrategy_which_is_used_to_calculate_the_unit_price_based_on_pricingstrategy()
        {
            var mockedPricingStrategy = new Mock<PricingStrategy>();
            mockedPricingStrategy.Setup((x) => x.GetUnitPrice()).Returns(9M);

            var item = new Item("Apple juice 2Ltr");
            item.SetPricingStrategy(mockedPricingStrategy.Object);

            decimal price = item.GetPrice();
            Assert.AreEqual<decimal>(9M, price);
        }
    }
}