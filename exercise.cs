using System;
using System.Math;
using Basket.FakeItem;

namespace Basket
{
    public class BasketTotalCalculator
    {
        public decimal SubTotal { get; set; }

        public decimal AddBasketItems(Basket basket)
        {
            foreach (item in basket.Items)
            {
                Subtotal += item.Price; // Quick and dirty, ignores item amount as it's not available yet.
            }
    }
}
