using Xunit;
using DivisorPairs.Services;

namespace DivisorPairs.Tests
{
    public class DivisorServiceTests
    {
        private readonly DivisorService _service;

        public DivisorServiceTests()
        {
            _service = new DivisorService();
        }

        [Fact]
        public void Test_SmallInput()
        {
            int result = _service.CountValidN(15);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Test_MinEdge()
        {
            int result = _service.CountValidN(2);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Zero()
        {
            int result = _service.CountValidN(0);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_Negative()
        {
            int result = _service.CountValidN(-10);
            Assert.Equal(0, result);
        }

        [Fact]
        public void Test_MediumInput()
        {
            int result = _service.CountValidN(50);
            Assert.True(result >= 0);
        }

        [Fact]
        public void Test_Consistency()
        {
            int result1 = _service.CountValidN(20);
            int result2 = _service.CountValidN(20);

            Assert.Equal(result1, result2);
        }
    }
}