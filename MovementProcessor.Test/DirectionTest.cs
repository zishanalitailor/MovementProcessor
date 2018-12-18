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
            const char expectedDirection = 'W';

            //act
            char resultDirection = directionChanger.GetDirection('N', Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingSouthAndInstructedToTurnLeft_ItShouldFaceEastDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'E';

            //act
            char resultDirection = directionChanger.GetDirection('S', Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingWestAndInstructedToTurnLeft_ItShouldFaceSouthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'S';

            //act
            char resultDirection = directionChanger.GetDirection('W', Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingEastAndInstructedToTurnLeft_ItShouldFaceNorthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'N';

            //act
            char resultDirection = directionChanger.GetDirection('E', Rotation.Anticlockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }


        // right direction test
        [TestMethod]
        public void Test_WhenRobotIsFacingNorthAndInstructedToTurnRight_ItShouldFaceEastDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'E';

            //act
            char resultDirection = directionChanger.GetDirection('N', Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingSouthAndInstructedToTurnRight_ItShouldFaceWestDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'W';

            //act
            char resultDirection = directionChanger.GetDirection('S', Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingWestAndInstructedToTurnRight_ItShouldFaceNorthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'N';

            //act
            char resultDirection = directionChanger.GetDirection('W', Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }

        [TestMethod]
        public void Test_WhenRobotIsFacingEastAndInstructedToTurnRight_ItShouldFaceSouthDirection()
        {
            //arrange
            IDirectionChanger directionChanger = new DirectionChanger();
            const char expectedDirection = 'S';

            //act
            char resultDirection = directionChanger.GetDirection('E', Rotation.Clockwise);

            //assert
            Assert.AreEqual(resultDirection, expectedDirection);
        }
    }
}
