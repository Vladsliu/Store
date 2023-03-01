using Xunit;

namespace Store.Web.Domain
{
    public class OrderTests
    {
        [Fact]
        public void Order_WithNullItems_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Order(1, null));
        }

        [Fact]
        public void TotalCount_WidthEmptyItems_ReturnsZero()
        {
            var order = new Order(1, new OrderItem[0]);

            Assert.Equal(0, order.TotalCount);
        }

        [Fact]
        public void TotalPrice_WidthEmptyItems_ReturnsZero()
        {
            var order = new Order(1, new OrderItem[0]);

            Assert.Equal(0m, order.TotalCount);
        }
    }
}
