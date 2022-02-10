using NUnit.Framework;

namespace ConsoleApp.UnitTests
{
    public class OrderTest
    {
        [Test]
        public void CalcTax_傳入未稅金額_傳回五趴營業稅()
        {
            decimal price = 100;
            var order = new UnitTest.Program.Order();
            decimal tax = order.CalcTax(price);

            //把預期等於的值填入第一個參數，錯誤的話會跑出來
            Assert.AreEqual(5M, tax);
        }
        //簡化寫法，改成帶入數字
        //190 * 0.05 = 9.5 =>10
        [TestCase(190,10)]
        //210 * 0.05 = 10.5 =>10
        [TestCase(210, 11)]

        public void CalcTax_傳入無法整除的未稅金額_傳回四捨五入後的營業稅(decimal price,decimal exptected)
        {
            var order = new UnitTest.Program.Order();
            decimal tax = order.CalcTax(price);
            Assert.AreEqual(exptected, tax);
        }
    }
}
