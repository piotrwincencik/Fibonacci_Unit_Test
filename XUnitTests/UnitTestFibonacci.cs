using Fibonacci_Unit_Test;
using System;
using Xunit;
 
namespace UnitTestFibonacci
{
    public class FibonacciUnitTest
    {
        [Fact]
        public void Fibonacci1() //sprawdza ile fibonnaci wynosi dla 1
        {
            //arrange
            var fibonnaci = new Fibonacci();
            //act
            var result = fibonnaci.Kalkulator(1);
            //assert
            Assert.Equal(1, result);
        }
        [Fact]
        public void Fibonacci2() //sprawdza ile fibonnaci wynosi dla 25
        {
            //arrange
            var fibonnaci = new Fibonacci();
            //act
            var result = fibonnaci.Kalkulator(25);
            //assert
            Assert.Equal(75025, result);
        }
        [Fact]
        public void Fibonacci3() //sprawdza ile fibonnaci wynosi dla 7
        {
            //arrange
            var fibonnaci = new Fibonacci();
            //act
            var result = fibonnaci.Kalkulator(7);
            //assert
            Assert.Equal(13, result);
        }
    }
}