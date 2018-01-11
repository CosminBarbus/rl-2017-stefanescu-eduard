using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void Add_Add1Product_Successfully()
        {
            oreoBand.Add(oreoItem);

            Assert.AreEqual(1, oreoBand.Count());
        }

        [TestMethod]
        public void Add_AddProductsUntillBandIsFull_BandSizeIs0()
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
            oreoBand.Add(oreoItem);

            Assert.AreEqual(-1, oreoBand.BandSize);
        }

        [TestMethod]
        public void Remove_BandHave2ProductsRemove1Product_Successfully()
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
        public void Remove_BandIsEmptyRemove1Product_Failed()
        {
            oreoBand.Remove(oreoItem);

            Assert.AreEqual(21, oreoBand.BandSize);
        }

        [TestMethod]
        public void Count_Add3Products_CountReturns3()
        {
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);
            oreoBand.Add(oreoItem);

            Assert.AreEqual(3, oreoBand.Count());
        }

        [TestMethod]
        public void GetFirstItem_Get1ProductWithSameName_Successfully()
        {
            ContainableItem oreo = new ContainableItem();

            oreoBand.Add(oreoItem);
            oreo = oreoBand.GetFirstItem();

            Assert.AreEqual(oreoProduct.Name, oreo.Product.Name);
        }

        [TestMethod]
        public void GetFirstItem_Get1ProductWithDifferentName_Failed()
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
        public void GetFirstItem_Get1ProductWhenBandIsEmpty_ReturnEmptyProduct()
        {
            ContainableItem oreo = new ContainableItem();

            oreo = oreoBand.GetFirstItem();

            Assert.AreEqual(0, oreo.Size);
        }
    }
}
