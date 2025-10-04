using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Src.UnitTests.Dependencies.DependenciesRelationShip
{
    public class Cart
    {
        private readonly List<CartItem> items =new List<CartItem> ();
        //private readonly  UserAuthentication _userAuthentication;
        public Cart(/*UserAuthentication userAuthentication*/)
        {
            //_userAuthentication = userAuthentication;
        }
        public bool AddItemCart(CartItem cartItem) 
        {
            //if (!_userAuthentication.IsAuthenticated)
            //    throw new InvalidOperationException("user must be logged in to the add item to the cart! ");
            items.Add(cartItem);
            return true;
        }

        public decimal CalculateTotal() 
        {
            decimal total = 0m;
            foreach (var  item in items)
                total += item.Amount;
            return total;
            

        }
    }
    public class CartItem
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }

}
