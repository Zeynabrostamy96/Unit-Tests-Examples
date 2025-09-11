using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.UnitTests.TestsFundamental
{
    public class TestCustomerController
    {
        [Fact]
        public void GetCustomer_IdIsZero_ReturnNotFond()
        {
            //Arrange
            var controller = new CustomerController();


            //Act
            var result = controller.GetCustomer(0);

            //Assert

            Assert.IsType<CustomerController.NotFound>(result);
        }
        [Fact]
        public void GetCustomer_IdNotZero_ReturnOk()
        {
            //Arrange

            var Controller = new CustomerController();

            //Act
            var result = Controller.GetCustomer(1);

            //Assert
            Assert.IsType<CustomerController.Ok>(result);

        }
    }
}
