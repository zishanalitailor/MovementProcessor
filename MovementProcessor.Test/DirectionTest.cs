using System;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting; 
using MovementProcessor.Domain.Helper;
using MovementProcessor.Interfaces;
using MovementProcessor.Business;

namespace MovementProcessor.Test
{
    [TestClass]
    public class DirectionTest
    {
        [TestMethod]
        public void Test_WhenRobotIsFacingNorthAndInstructedToTurnLeft_ItShouldFaceWestDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.West;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.North, Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingSouthAndInstructedToTurnLeft_ItShouldFaceEastDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.East;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.South, Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingWestAndInstructedToTurnLeft_ItShouldFaceSouthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.South;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.West, Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingEastAndInstructedToTurnLeft_ItShouldFaceNorthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.North;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.East, Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }


        // right direction test
        [TestMethod]
        public void Test_WhenRobotIsFacingNorthAndInstructedToTurnRight_ItShouldFaceEastDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.East;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.North, Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingSouthAndInstructedToTurnRight_ItShouldFaceWestDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.West;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.South, Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingWestAndInstructedToTurnRight_ItShouldFaceNorthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.North;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.West, Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingEastAndInstructedToTurnRight_ItShouldFaceSouthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            Direction expectedDirection = Direction.South;

            //act
            Direction resultDirection = directionChanger.GetDirection(Direction.East, Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }
    }
}
