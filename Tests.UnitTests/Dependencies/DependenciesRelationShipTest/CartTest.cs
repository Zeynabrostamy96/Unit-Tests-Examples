using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Dependencies;
using Tests.Src.UnitTests.Dependencies.DependenciesRelationShip;
using Xunit;

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
    }

}
