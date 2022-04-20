using Xunit;

namespace FizzBuzz.Test
{
    public class GameTest
    {
        //[Fact]
        //public void IsExist()
        //{
        //    var game = new FizzBuzz.FizzBuzzGame();
        //    string result = game.Play(3);



        //}

        /*
         * Ben bir oyuncu olarak, 
         * 3 sayısını verdiğimde
         * Bana Fizz dönmeli
         */
        FizzBuzzGame game = new FizzBuzzGame();
        [Fact]
        public void When_Give_3_Return_Fizz()
        {
            //Arrange
         
            //Act
            string result = game.Play(3);

            //Assert
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void When_Give_5_ReturnBuzz()
        {
            string result = game.Play(5);
            Assert.Equal("Buzz", result);
        }
        [Theory]      
        [InlineData(6)]
        [InlineData(9)]
        [InlineData(12)]
        public void When_Give_Multiply_3_Return_Fizz(int value)
        {
            string result = game.Play(value);
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(10)]
        [InlineData(20)]
        [InlineData(25)]
        public void When_Give_Multiply_5_Return_Buzz(int value)
        {
            string result = game.Play(value);
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(45)]
        public void When_Give_Multiply_15_Return_FizzBuzz(int value)
        {
            string result = game.Play(value);
            Assert.Equal("FizzBuzz", result);
        }


        [Theory]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(7)]
        public void When_Give_Number_Return_Number(int value)
        {
            string result = game.Play(value);
            Assert.Equal(value.ToString(), result);
        }
    }
}