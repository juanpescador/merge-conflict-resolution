using System;
using System.Math;

namespace Basket
{
    public class BasketTotalCalculator
    {
        public decimal SubTotal { get; set; }

        public decimal AddBasketItems(Basket basket)
        {
            foreach (item in basket.Items)
            {
                Subtotal += 10; // Don't have access to item price yet, assume each item costs 10.
            }
    }
}
