using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class DispenserTesets
    {
        ProductCategory skittlesCategory;
        Product skittlesProduct;
        ProductPosition skittlesPosition;
        ContainableItem skittlesItem;
        ProductBand skittlesBand;
        Dispenser dispenser;

        [TestInitialize]
        public void InitializeConstructors()
        {
            skittlesCategory = new ProductCategory("Biscuits", "Biscuits with cream");
            skittlesProduct = new Product("Oreo", 5.59, skittlesCategory);
            skittlesPosition = new ProductPosition(3, 7);
            skittlesItem = new ContainableItem(skittlesPosition, 2, skittlesProduct);
            skittlesBand = new ProductBand(new List<ContainableItem>());
            dispenser = new Dispenser(new List<ProductBand>());
        }

        [TestMethod]
        public void AddCell_Add1Cell_SuccesfullyCountReturn1()
        {
            dispenser.AddCell(skittlesBand);

            Assert.AreEqual(1, dispenser.Bands.Count);
        }

        [TestMethod]
        public void AddCell_AddSameTypeCellInDispenser_FailedCountReturn1()
        {
            skittlesBand.Add(skittlesItem);
            dispenser.AddCell(skittlesBand);
            dispenser.AddCell(skittlesBand);

            Assert.AreEqual(1, dispenser.Bands.Count);
        }

        [TestMethod]
        public void Dispense_Dispense1ProductWhenBandHas10ProductsWithSize2_CountReturn9()
        {
            dispenser.AddCell(skittlesBand);
            for (int item = 0; item < 10; item++)
                skittlesBand.Add(skittlesItem);
            dispenser.Dispense(skittlesItem);

            Assert.AreEqual(9, skittlesBand.Count());
        }
    }
}
