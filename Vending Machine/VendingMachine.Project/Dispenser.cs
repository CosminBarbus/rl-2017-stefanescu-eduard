using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    public class Dispenser:IPaymentSubscriber
    {
        private List<ProductBand> bands;

        public Dispenser()
        {
            this.bands = new List<ProductBand>();
        }
        public void Dispense()
        {

        }
        public void DispenseProduct(string productName)
        {
            // search product band
            // remove from product band

        }

        public void Add(ProductBand pringlesBand)
        {
            this.bands.Add(pringlesBand);
        }
    }
}
