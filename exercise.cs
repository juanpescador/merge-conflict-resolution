using System;
using Basket.Item;
using System.Math;
using Basket.FakeItem;

namespace Basket
{
    public class BasketTotalCalculator
    {
        public decimal SubTotal { get; set; }

        public decimal CalculateBasketSubTotal(Basket basket)
        {
            foreach (item in basket.Items)
            {
                Subtotal += item.Amount * item.Price;
            }
    }
}
