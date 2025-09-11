using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tests.Src.UnitTests.Fundamentals;
using Xunit;

namespace Tests.UnitTests.TestFundamentals
{
    public class TestDemeritPointsCalculator
    {
        public void CalculateDemeritPoints_SpeedBelowOrEqualToLimit_ReturnsZero() 
        {
            //Arrange

            var demeritpoints=new DemeritPointsCalculator();

            //Act
            var result = demeritpoints.CalculateDemeritPoints(65);

            //Assert
            Assert.Equal(0,result);

        }
    }
}
