using FluentAssertions;
using FluentAssertions.Extensions;
using System.Net.NetworkInformation;
using xUnit_FluidAssertionExample.Classes;

namespace xUnit_FluidAssertionExample.Tests.ClassesTests
{
    public class ClassExampleTests
    {
        private readonly ClassExample _classExample;
        public ClassExampleTests()
        {
            _classExample= new ClassExample();
        }

        [Fact]
        public void ClassExample_returnFoxIfZero_ReturnString()
        {
            //Arrange
            //var classExample = new ClassExample();

            //Act
            var result = _classExample.returnFoxIfZero(0);

            //Assert
            result.Should().Be("Fox");
        }

        [Theory]
        [InlineData(4, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        public void ClassExample_wynik_ReturnInt(int a, int b)
        {
            //Arrange

            //Act
            var result = _classExample.sumResult(a, b);
            //Assert
            result.Should().BeGreaterThan(2);
        }

        [Fact]
        public void ClassExample_LastPingDate_ReturnDate()
        {
            var result = _classExample.LastPingDate();

            result.Should().BeAfter(1.January(2010));
            result.Should().BeBefore(1.January(2030));
        }

        [Fact]
        public void ClassExample_GetPingOptions_ReturnObject()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _classExample.GetPingOptions();

            result.Should().BeOfType<PingOptions>();
            result.Should().BeEquivalentTo(expected);
            result.Ttl.Should().Be(1);
        }

        [Fact]
        public void ClassExample_MostRecentPings_ReturnsIEnumerable()
        {
            var expected = new PingOptions()
            {
                DontFragment = true,
                Ttl = 1
            };

            var result = _classExample.MostRecentPings();

            result.Should().ContainEquivalentOf(expected);
            result.Should().Contain(x => x.DontFragment == true);
        }
    }
}
