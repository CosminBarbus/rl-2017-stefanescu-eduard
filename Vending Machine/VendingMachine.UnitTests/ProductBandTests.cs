using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.UnitTests.Exceptions;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class ProductBandTest
    {
        ProductCategory oreoCategory;
        Product oreoProduct;
        ProductPosition oreoPosition;
        ContainableItem oreoItem;
        ProductBand oreoBand;

        [TestInitialize]
        public void InitializeConstructors()
        {
            oreoCategory = new ProductCategory("Biscuits", "Biscuits with cream");
            oreoProduct = new Product("Oreo", 5.59, oreoCategory);
            oreoPosition = new ProductPosition(3, 7);
            oreoItem = new ContainableItem(oreoPosition, 5, oreoProduct);
            oreoBand = new ProductBand(new List<ContainableItem>());
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
        public void Add_AddProductsOverBandSize_Failed()
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
        public void Remove_BandIsFullRemoveAllProducts_Successfully()
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
        public void Remove_BandIsEmptyRemoveOneProduct_Failed()
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

            Assert.AreEqual(oreoProduct.Name, oreo.Product.Name);
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWithDifferentName_Failed()
        {
            ProductCategory skittlesCategory = new ProductCategory("Sweets", "Colorated sweets");
            Product skittlesProduct = new Product("Skittles", 5.77, skittlesCategory);
            ProductPosition skittlesPosition = new ProductPosition(3, 5);
            ContainableItem skittlesItem = new ContainableItem(skittlesPosition, 3, skittlesProduct);
            ContainableItem skittles = new ContainableItem();

            skittles = oreoBand.GetFirstItem();

            Assert.AreNotEqual(skittlesProduct.Name, oreoProduct.Name);
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWhenBandIsEmpty_ReturnEmptyProduct()
        {
            ContainableItem oreo = new ContainableItem();

            oreo = oreoBand.GetFirstItem();

            Assert.AreEqual(0, oreo.Size);
        }
    }
}
