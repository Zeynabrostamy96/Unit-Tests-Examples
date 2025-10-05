using FluentAssertions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Dependencies;
using Tests.Src.UnitTests.Dependencies.DependenciesRelationShip;
using Xunit;
using NSubstitute;

namespace Tests.UnitTests.Dependencies.DependenciesRelationShipTest
{
    public class CartTest
    {




        [Fact]
        public void AddItemToCart_ShouldFali_IfNotLoggin() 
        {
            var auth = new UserAuthentication();
   
            //var cart = new Cart(auth);

            //Assert.Throws<InvalidOperationException>(() => cart.AddItemCart("iphone"));

        }
        [Fact]
        public void SearchAndAddItem_shouldBeIndependent()
        {

            var search = new Search();
            var searchItem = search.SearchItem("iphone");


            var auth = new UserAuthentication();

            //var cart = new Cart(auth);

            //Assert.Throws<InvalidOperationException>(() => cart.AddItemCart("iphone"));

        }
        [Fact]
        public void Cart_ShouldCalculateTotalCorrectly()
        {

            var cart = new Cart();

            cart.AddItemCart(new CartItem {Amount=1.0m,Name="ipad" });
            cart.AddItemCart(new CartItem {Amount=2.0m,Name="iphone" });
            cart.AddItemCart(new CartItem {Amount=3.0m,Name="imac" });


            var result= cart.CalculateTotal();

            result.Should().Be(6);



        }
        [Fact]
        public void Payment_ShouldProcessCorrectly_WithDiffrentMethod()
        {
            PaymentMethod method1 = new CarditCardPayment();
            PaymentMethod method2 = new PayPalPayment(); 


            method1.Process(100).Should().BeTrue();
            method2.Process(100).Should().BeTrue();

           



        }


        [Fact]
        public void Receipt_ShouldGenerateCorrectly()
        {
            var goods = new List<Good>();
            goods.Add(new Good { Name = "harchi", Amount = 5m});
            goods.Add(new Good { Name = "harchi2", Amount = 2m });

            PaymentMethod method1 = new CarditCardPayment();
            var recepipt = new Receipt(goods,method1 );


            recepipt.GenerateReceipt().Length.Should().BeGreaterThan(1);

        }
        [Fact]
        public void Receipt_ShouldGenerateCorrectly_SendDate()
        {
            ApiClient apiClient = new ApiClient();
            var receipt = new OrderService(apiClient);

            receipt.SendDate("test").Should().BeTrue();
        }

        [Fact]
        public void Receipt_ShouldGenerateIncorrect_SendDate()
        {
            var apiClient = Substitute.For<IApiClient>();
            apiClient.GetKay(Arg.Any<string>()).Returns((strr) =>  throw new Exception());
      
            var receipt = new OrderService(apiClient);

            receipt.SendDate("test").Should().BeFalse();
        }

    }

}
