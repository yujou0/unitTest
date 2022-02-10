using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public class Order
        {
            ///<summary>
            ///計算營業稅
            ///</summary>
            ///<param name="price"></param>
            ///<returns></returns>
            public decimal CalcTax(decimal price)
            {
                //原本Math.Round()是四捨六入五成雙
                //return Math.Round(price / 20);

                //改寫後是平常常見的四捨五入
                return Math.Round(price / 20,MidpointRounding.AwayFromZero);
            }
        }
    }
}
