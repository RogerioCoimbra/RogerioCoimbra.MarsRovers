using System;
using RogerioCoimbra.MarsRovers.Domain.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RogerioCoimbra.MarsRovers.Test
{
    [TestClass]
    public class PlateauTest
    {
        [TestMethod]
        public void Given_Rover_In_Valid_Position_1_When_Check_If_Is_Inside_Plateau_Then_Return_True()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(1, 3);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void Given_Rover_In_Valid_Position_2_When_Check_If_Is_Inside_Plateau_Then_Return_True()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(1, 6);

            //assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Given_Rover_In_Invalid_Position_1_When_Check_If_Is_Inside_Plateau_Then_Return_False()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(1, 6);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Rover_In_Invalid_Position_2_When_Check_If_Is_Inside_Plateau_Then_Return_False()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(6, 1);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Rover_In_Invalid_Position_3_When_Check_If_Is_Inside_Plateau_Then_Return_False()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(3, -1);

            //assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void Given_Rover_In_Invalid_Position_4_When_Check_If_Is_Inside_Plateau_Then_Return_False()
        {
            //arrange
            var plateau = new Plateau(5, 5);

            //act
            var result = plateau.IsRoverInsideBoundaries(-1, 3);

            //assert
            Assert.IsFalse(result);
        }
    }
}
