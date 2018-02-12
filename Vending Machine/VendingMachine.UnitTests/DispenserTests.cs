using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.ConsoleUI.Exceptions;
using VendingMachine.Project;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class DispenserTests
    {
        private ContainableItem skittlesItem;
        private ProductBand skittlesBand;
        private Dispenser dispenser;

        [TestInitialize]
        public void InitializeConstructors()
        {
            skittlesItem = ProductFactory.CreateSkittlesProduct();
            skittlesBand = new ProductBand();
            dispenser = new Dispenser();
        }

        [TestMethod]
        public void Dispense_DispeneseOneProductBandHasTwoItems_CountReturnOne()
        {
            skittlesBand.Add(skittlesItem);
            skittlesBand.Add(skittlesItem);
            
            dispenser.Dispense(skittlesItem);

            Assert.AreEqual(1, skittlesBand.Count());
        }

        [TestMethod]
        public void Dispense_DispenseOneProductBandIsEmpty_Failed()
        {
            

            Assert.ThrowsException<BandIsEmptyException>(() => dispenser.Dispense(skittlesItem));
        }
    }
}
