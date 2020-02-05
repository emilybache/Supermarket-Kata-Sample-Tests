using Xunit;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest1
    {
        private Checkout checkout;

        public SupermarketTest1()
        {
            checkout = new Checkout();
        }

        [Fact]
        public void TestCheckoutWithSpecialPriceCriteriaMetReturnsSpecialPrice()
        {
            checkout.AddPricingRule(ItemARule);
            AddItems(3, itemA);
            int result = checkout.CalculateTotal();
            Assert.Equal(130, result);
        }

        private readonly Item itemA = new Item
        {
            Name = "A",
            Price = 50
        };

        private readonly PricingRule ItemARule = new PricingRule
        {
            ItemName = "A",
            ItemCount = 3,
            Total = 130
        };


        private void AddItems(int count, Item item)
        {
            for (int i = 0; i < count; i++)
            {
                checkout.AddItem(item);
            }
        }
    }
}