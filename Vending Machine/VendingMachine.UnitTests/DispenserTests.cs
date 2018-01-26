using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.UnitTests.Exceptions;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class DispenserTests
    {
        private ProductCategory skittlesCategory;
        private Product skittlesProduct;
        private ProductPosition skittlesPosition;
        private ContainableItem skittlesItem;
        private ProductBand skittlesBand;
        private Dispenser dispenser;

        [TestInitialize]
        public void InitializeConstructors()
        {
            skittlesCategory = new ProductCategory("Biscuits", "Biscuits with cream");
            skittlesProduct = new Product("Oreo", 5.59, skittlesCategory);
            skittlesPosition = new ProductPosition(2, 5);
            skittlesItem = new ContainableItem(skittlesPosition, 2, skittlesProduct);
            skittlesBand = new ProductBand(new List<ContainableItem>());
            dispenser = new Dispenser();
        }

        [TestMethod]
        public void Dispense_DispeneseOneProductBandHasTwoItems_CountReturnOne()
        {
            skittlesBand.Add(skittlesItem);
            skittlesBand.Add(skittlesItem);
            dispenser.Dispense(skittlesBand, skittlesItem);

            Assert.AreEqual(1, skittlesBand.Count());
        }

        [TestMethod]
        public void Dispense_DispenseOneProductBandIsEmpty_Failed()
        {
            Assert.ThrowsException<BandIsEmptyException>(() => dispenser.Dispense(skittlesBand, skittlesItem));
        }
    }
}
