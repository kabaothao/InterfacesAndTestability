using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfacesAndTestability.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        //METHOODNAME_CONDITION_EXPECTATION
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };

            orderProcessor.Process(order);
        }
    }



    [TestMethod]
    public void Process_OrderIsNoteShipped_ShouldSetTheShipmentPropertyofTheOrder()
    {
        var orderProcessor = new OrderProcessorTests(new FakeShippingCalculator());
        var order = new OrderProcessorTests();

        orderProcessor.Process(order);

        Assert.IsTrue(order.IsShipped);
        Assert.AreEqual(1, order.Shipment.Cost);
        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }



    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }

    }



}


/*
 Note that each test class as an attribute called Test class and it can have a bunch of methods like

the one you see here which are decorated with test method attributes in C-sharp attributes represent

meta data about your classes and their members.

They don't have any logic there are just markers.

Then another application or another assembly can read this method data and do something about it.

For example later you're going to see that we're going to use Microsoft test runner and that test runner

 */