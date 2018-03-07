using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class DispenserTests
    {
        private ContainableItem _skittlesItem;
        private ProductBand _skittlesBand;
        private Dispenser _dispenser;

        [TestInitialize]
        public void InitializeConstructors()
        {
            _skittlesItem = ProductFactory.CreateSkittlesProduct();
            _skittlesBand = ProductBand.Instance;
            _dispenser = new Dispenser();
        }

        [TestCleanup]
        public void CleanupProductBand()
        {
            foreach (var product in _skittlesBand.Products)
                _skittlesBand.Remove(product);
        }

        [TestMethod]
        public void Dispense_DispeneseOneProductBandHasTwoItems_CountReturnOne()
        {
            _skittlesBand.Add(_skittlesItem);
            _skittlesBand.Add(_skittlesItem);

            _dispenser.OnPay(_skittlesItem);

            Assert.AreEqual(1, _skittlesBand.Count());
        }

        [TestMethod]
        public void Dispense_DispenseOneProductBandIsEmpty_ThrowBandIsEmptyException()
        {
            Assert.ThrowsException<BandIsEmptyException>(() => _dispenser.OnPay(_skittlesItem));
        }
    }
}
