using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class ProductBandTest
    {
        private ContainableItem _oreoItem;
        private ProductBand _oreoBand;

        [TestInitialize]
        public void InitializeConstructors()
        {
            _oreoItem = ProductFactory.CreateOreoItem();
            _oreoBand = ProductBand.Instance;
        }

        [TestCleanup]
        public void CleanupProductBand()
        {
            foreach (var product in _oreoBand.Products)
                _oreoBand.Remove(product);
        }

        [TestMethod]
        public void Add_AddOneProduct_Successfully()
        {
            _oreoBand.Add(_oreoItem);

            Assert.AreEqual(1, _oreoBand.Count());
        }

        [TestMethod]
        public void Add_AddProductsUntillBandIsFull_BandSizeIsZero()
        {
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);

            Assert.AreEqual(0, _oreoBand.BandSize);
        }

        [TestMethod]
        public void Add_AddProductsOverBandSize_ThrowBandIsFullException()
        {
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);

            Assert.ThrowsException<BandIsFullException>(() => _oreoBand.Add(_oreoItem));
        }

        [TestMethod]
        public void Remove_BandHaveTwoProductsRemoveOneProduct_Successfully()
        {
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Remove(_oreoItem);

            Assert.AreEqual(1, _oreoBand.Count());
        }

        [TestMethod]
        public void Remove_WhenBandIsFullRemoveAllProducts_Successfully()
        {
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Remove(_oreoItem);
            _oreoBand.Remove(_oreoItem);
            _oreoBand.Remove(_oreoItem);
            _oreoBand.Remove(_oreoItem);

            Assert.AreEqual(0, _oreoBand.Count());
        }

        [TestMethod]
        public void Remove_RemoveOneProductWhenBandIsEmpty_ThrowBandIsEmptyException()
        {
            Assert.ThrowsException<BandIsEmptyException>(() => _oreoBand.Remove(_oreoItem));
        }

        [TestMethod]
        public void Count_AddThreeProducts_CountReturnsThree()
        {
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);
            _oreoBand.Add(_oreoItem);

            Assert.AreEqual(3, _oreoBand.Count());
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWithSameName_Successfully()
        {
            _oreoBand.Add(_oreoItem);
            var oreo = _oreoBand.GetFirstItem();

            Assert.AreEqual(_oreoItem.Product.Name, oreo.Product.Name);
        }

        [TestMethod]
        public void GetFirstItem_GetOneProductWithDifferentName_Failed()
        {
            _oreoBand.Add(_oreoItem);
            var skittles = _oreoBand.GetFirstItem();

            Assert.AreNotEqual("Skittles", skittles.Product.Name);
        }

        [TestMethod]
        public void GetByName_GetOreoItemByName_Successfully()
        {
            _oreoBand.Add(_oreoItem);
            var oreo = _oreoBand.GetByName("Oreo");

            Assert.AreEqual("Oreo", oreo.Product.Name);
        }

        [TestMethod]
        public void GetByName_GetOreoItemByNameWhenBandIsEmpty_ThrowProductNotFoundException()
        {
            Assert.ThrowsException<ProductNotFoundException>(() => _oreoBand.GetByName("Oreo"));
        }
    }
}
