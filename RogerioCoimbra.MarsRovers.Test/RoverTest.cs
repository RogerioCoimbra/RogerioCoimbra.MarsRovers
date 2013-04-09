using System;
using RogerioCoimbra.MarsRovers.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RogerioCoimbra.MarsRovers.Test
{
    /// <remarks>
    /// Não permiti que a sonda saísse da planície.
    /// Quando ela chega à borda e a direção esta para fora eu anulo o movimento.
    /// </remarks>
    [TestClass]
    public class RoverTest
    {
        [TestMethod]
        public void Given_Rover_In_Valid_Position_1_When_Navigate_Then_Return_Coordinate_And_Orientation_Correct()
        {
            //arrange
            var plateau = new Plateau(5, 5);
            var rover = new Rover(1, 2, Orientation.North, plateau);

            //act
            var result = rover.Navigate("LMLMLMLMM").GetCurrentPosition();

            //assert
            Assert.AreEqual<string>("1 3 N", result);
        }

        [TestMethod]
        public void Given_Rover_In_Valid_Position_2_When_Navigate_Then_Return_Coordinate_And_Orientation_Correct()
        {
            //arrange
            var plateau = new Plateau(5, 5);
            var rover = new Rover(3, 3, Orientation.East, plateau);

            //act
            var result = rover.Navigate("MMRMMRMRRM").GetCurrentPosition();

            //assert
            Assert.AreEqual<string>("5 1 E", result);
        }

        [TestMethod]
        public void Given_Rover_In_Valid_Position_3_When_Navigate_Then_Return_Coordinate_And_Orientation_Correct()
        {
            //arrange
            var plateau = new Plateau(5, 5);
            var rover = new Rover(0, 1, Orientation.North, plateau);

            //act
            var result = rover.Navigate("LMLMLMLMM").GetCurrentPosition();

            //assert
            Assert.AreEqual<string>("1 2 N", result);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Given_Rover_In_Valid_Position_1_When_Navigate_Then_Return_Coordinate_And_Orientation_Incorrect()
        {
            //arrange
            var plateau = new Plateau(5, 5);
            var rover = new Rover(0, 1, Orientation.North, plateau);

            //act
            var result = rover.Navigate("LMLMLMLMM").GetCurrentPosition();

            //assert
            Assert.AreEqual<string>("0 0 N", result);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Given_Rover_In_Valid_Position_2_When_Navigate_Then_Return_Coordinate_And_Orientation_Incorrect()
        {
            //arrange
            var plateau = new Plateau(5, 5);
            var rover = new Rover(0, 0, Orientation.North, plateau);

            //act
            var result = rover.Navigate("LMLMLMLMM").GetCurrentPosition();

            //assert
            Assert.AreEqual<string>("5 5 N", result);
        }
    }
}
