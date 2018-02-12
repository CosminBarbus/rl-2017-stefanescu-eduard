using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.ConsoleUI.Exceptions;
using VendingMachine.Project;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class ProductBandTest
    {
        private ContainableItem oreoItem;
        private ProductBand oreoBand;

        [TestInitialize]
        public void InitializeConstructors()
        {
            oreoItem = ProductFactory.CreateOreoItem();
            oreoBand = new ProductBand();
        }

        [TestMethod]
        public void Add_AddOneProduct_Successfully()
        {
            oreoBand.Add(oreoItem);

            Assert.AreEqual(1, oreoBand.Count());
        }

        [TestMethod]
        public void Add_AddProductsUntillBandIsFull_BandSizeIsZero()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);

            Assert.AreEqual(0, oreoBand.BandSize);
        }

        [TestMethod]
        public void Add_AddProductsOverBandSize_ThrowBandIsFullException()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);

            Assert.ThrowsException<BandIsFullException>(() => oreoBand.Add(oreoItem));
        }

        [TestMethod]
        public void Remove_BandHaveTwoProductsRemoveOneProduct_Successfully()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Remove(oreoItem);

            Assert.AreEqual(1, oreoBand.Count());
        }

        [TestMethod]
        public void Remove_WhenBandIsFullRemoveAllProducts_Successfully()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Remove(oreoItem);
            oreoBand.Remove(oreoItem);
            oreoBand.Remove(oreoItem);
            oreoBand.Remove(oreoItem);

            Assert.AreEqual(0, oreoBand.Count());
        }

        [TestMethod]
        public void Remove_RemoveOneProductWhenBandIsEmpty_ThrowBandIsEmptyException()
        {
            Assert.ThrowsException<BandIsEmptyException>(() => oreoBand.Remove(oreoItem));
        }

        [TestMethod]
        public void Count_AddThreeProducts_CountReturnsThree()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);

            Assert.AreEqual(3, oreoBand.Count());
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWithSameName_Successfully()
        {
            ContainableItem oreo = new ContainableItem();

            oreoBand.Add(oreoItem);
            oreo = oreoBand.GetFirstItem();

            Assert.AreEqual(oreoItem.Product.Name, oreo.Product.Name);
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWithDifferentName_Failed()
        {
            ContainableItem skittles = new ContainableItem();

            oreoBand.Add(oreoItem);
            skittles = oreoBand.GetFirstItem();

            Assert.AreNotEqual("Skittles", skittles.Product.Name);
        }
    }
}
