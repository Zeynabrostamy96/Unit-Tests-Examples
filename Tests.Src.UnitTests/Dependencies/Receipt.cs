using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies
{
    public class Receipt
    {
        private List<Good> goods;
        private PaymentMethod PaymentMethod;
        public Receipt(List<Good> goods, PaymentMethod paymentMethod)
        {
            this.goods=goods;
            this.PaymentMethod=paymentMethod;
        }
        public string GenerateReceipt()
        {
            var total = goods.Sum(x => x.Amount);
            return $"Totla:{total} and paid with PM:{PaymentMethod.GetType().Name}";
        }
    }
    public class Good 
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}
