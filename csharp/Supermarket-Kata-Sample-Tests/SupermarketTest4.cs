using System.Collections.Generic;
using Xunit;

namespace Supermarket_Kata_Sample_Tests
{
    public class SupermarketTest4
    {
        private ICashRegister register;

        public SupermarketTest4()
        {
            IEnumerable<Product> products = new[]
            {
                new Product {SKU = 'A', Price = 50},
                new Product {SKU = 'B', Price = 30},
                new Product {SKU = 'C', Price = 20},
                new Product {SKU = 'D', Price = 15}
            };

            IEnumerable<Discount> discounts = new[]
            {
                new Discount {SKU = 'A', Quantity = 3, Value = 20},
                new Discount {SKU = 'B', Quantity = 2, Value = 15}
            };

            register = new CashRegister(products, discounts);
        }

        [Fact]
        public void No_items_returns_zero()
        {
            Assert.Equal(0, register.Scan("").Total());
        }

        [Theory]
        [InlineData("AAA", 130)]
        [InlineData("AAAB", 160)]
        [InlineData("AAABB", 175)]
        [InlineData("AAAAAA", 260)]
        [InlineData("AAAAAABB", 305)]
        [InlineData("BB", 45)]
        [InlineData("ABB", 95)]
        [InlineData("BBBB", 90)]
        [InlineData("BBBBACD", 175)]
        public void Scan_discounted_combinations_and_expect_correct_total(string scan, int expected)
        {
            Assert.Equal(expected, register.Scan(scan).Total());
        }
    }
}