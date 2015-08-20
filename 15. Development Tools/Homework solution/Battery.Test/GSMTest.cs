using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobilePhones;

namespace MobilePhonesTest
{
    [TestClass]
    public class GsmTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_shouldThrowIfModelIsNull()
        {
            GSM phone=new GSM(null, "Nokia");  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfModelIsWhiteSpace()
        {
            GSM phone = new GSM("  ", "Nokia");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfManufacturerIsNull()
        {
            GSM phone = new GSM("1100", null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void GSMCreate_ShouldThrowIfManufacturerIsWhiteSpace()
        {
            GSM phone = new GSM("1100", "   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GSM_ShouldThrowIfPriceIsNegative()
        {
            GSM phone = new GSM("Nokia", "1100", -1, null, null, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GSM_ShouldThrowIfDisplaySizeIsNegative()
        {
            GSM phone = new GSM("Apple", "iPhone6");
            phone.DisplaySize = -1;
        }
    
    }
}
