using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnit_FluidAssertionExample.Classes;

namespace xUnit_FluidAssertionExample.Tests.ClassesTests
{
    public class ClassExampleTests
    {
        [Fact]
        public void Klasa_returnFoxIfZero_ReturnString()
        {
            //Arrange
            var classExample = new ClassExample();

            //Act
            var result = classExample.returnFoxIfZero(0);

            //Assert
            result.Should().Be("Fox");
        }

        [Theory]
        [InlineData(4, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        public void Klasa_wynik_ReturnInt(int a, int b)
        {
            //
            var classExample = new ClassExample();

            //
            var result = classExample.sumResult(a, b);

            //
            result.Should().BeGreaterThan(2);

        }
    }
}
