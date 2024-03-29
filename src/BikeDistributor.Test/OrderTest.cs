﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BikeDistributor.Test
{
    [TestClass]
    public class OrderTest
    {
        private readonly BikeList bikeList;

        public OrderTest()
        {
            bikeList = new BikeList();
        }


        [TestMethod]
        public void ReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Defy"], 1));
            Assert.AreEqual(ResultStatementOneDefy, order.Receipt());
        }

        private const string ResultStatementOneDefy = @"Order Receipt for Anywhere Bike Shop
	1 x Giant Defy 1 = $1,000.00
Sub-Total: $1,000.00
Tax: $72.50
Total: $1,072.50";

        [TestMethod]
        public void ReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Elite"], 1));
            Assert.AreEqual(ResultStatementOneElite, order.Receipt());
        }

        private const string ResultStatementOneElite = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized Venge Elite = $2,000.00
Sub-Total: $2,000.00
Tax: $145.00
Total: $2,145.00";

        [TestMethod]
        public void ReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["DuraAce"], 1));
            Assert.AreEqual(ResultStatementOneDuraAce, order.Receipt());
        }

        private const string ResultStatementOneDuraAce = @"Order Receipt for Anywhere Bike Shop
	1 x Specialized S-Works Venge Dura-Ace = $5,000.00
Sub-Total: $5,000.00
Tax: $362.50
Total: $5,362.50";

        [TestMethod]
        public void HtmlReceiptOneDefy()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Defy"], 1));
            Assert.AreEqual(HtmlResultStatementOneDefy, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneDefy = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Giant Defy 1 = $1,000.00</li></ul><h3>Sub-Total: $1,000.00</h3><h3>Tax: $72.50</h3><h2>Total: $1,072.50</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneElite()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Elite"], 1));
            Assert.AreEqual(HtmlResultStatementOneElite, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneElite = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized Venge Elite = $2,000.00</li></ul><h3>Sub-Total: $2,000.00</h3><h3>Tax: $145.00</h3><h2>Total: $2,145.00</h2></body></html>";

        [TestMethod]
        public void HtmlReceiptOneDuraAce()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["DuraAce"], 1));
            Assert.AreEqual(HtmlResultStatementOneDuraAce, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneDuraAce = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Specialized S-Works Venge Dura-Ace = $5,000.00</li></ul><h3>Sub-Total: $5,000.00</h3><h3>Tax: $362.50</h3><h2>Total: $5,362.50</h2></body></html>";

        //Sample Test

        [TestMethod]
        public void ReceiptOneVilano()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Vilano"], 1));
            Assert.AreEqual(ResultStatementOneVilano, order.Receipt());
        }

        private const string ResultStatementOneVilano = @"Order Receipt for Anywhere Bike Shop
	1 x Urbana Vilano 1 = $2,100.00
Sub-Total: $2,100.00
Tax: $152.25
Total: $2,252.25";

        [TestMethod]
        public void HtmlReceiptOneVilano()
        {
            var order = new Order("Anywhere Bike Shop");
            order.AddLine(new Line(bikeList.bikes["Vilano"], 1));
            Assert.AreEqual(HtmlResultStatementOneVilano, order.HtmlReceipt());
        }

        private const string HtmlResultStatementOneVilano = @"<html><body><h1>Order Receipt for Anywhere Bike Shop</h1><ul><li>1 x Urbana Vilano 1 = $2,100.00</li></ul><h3>Sub-Total: $2,100.00</h3><h3>Tax: $152.25</h3><h2>Total: $2,252.25</h2></body></html>";

        //
    }
}


