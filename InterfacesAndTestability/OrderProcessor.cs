using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndTestability
{
    public class OrderProcessor
    {
        privately readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator) //We instantiate this object. And here's our order processing method. So in the process method we get the Order object first you see an example of defensive programming. So first I'm validating if the order is already shipped.
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order) //So in the process method we get the Order object first you see an example of defensive programming. So first I'm validating if the order is already shipped. If it's shipped I don't want to ship it again.
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }
}


/*
 
line 18-25
Now if the order is not shipped before we simply create an object of type shipment and assign it to

the shipment property the shipment class has two properties cost and shipping date to calculate the

costs. We use our shipping calculator. So we passed the order and that shipping calculator knows how much the shipping cost should be for an

order for shipping date. I have hardcoded a rule here that states shipping will be done the day after the order is submitted



 */