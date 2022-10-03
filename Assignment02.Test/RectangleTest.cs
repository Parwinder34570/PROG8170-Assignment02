using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment02;
using NUnit.Framework;

namespace Assignment02.Test
{
    [TestFixture]
    internal class RectangleTest
    {
        [Test]
        public void GetCurrentWidth_InputNothing_Output1()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 1;

            //Act
            int actual = rectangle.GetCurrentWidth();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetCurrentWidth_Input5and10_Output5()
        {
            Rectangle rectangle = new Rectangle(5, 10);

            //Arrange
            int expected = 5;

            //Act
            int actual = rectangle.GetCurrentWidth();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetCurrentWidth_Input23and10_Output23()
        {
            Rectangle rectangle = new Rectangle(23, 10);

            //Arrange
            int expected = 23;

            //Act
            int actual = rectangle.GetCurrentWidth();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetCurrentLength_InputNothing_Output1()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 1;

            //Act
            int actual = rectangle.GetCurrentWidth();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetCurrentLength_Input5and13_Output13()
        {
            Rectangle rectangle = new Rectangle(5, 13);

            //Arrange
            int expected = 13;

            //Act
            int actual = rectangle.GetCurrentLength();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetCurrentLength_Input23and17_Output17()
        {
            Rectangle rectangle = new Rectangle(23, 17);

            //Arrange
            int expected = 17;

            //Act
            int actual = rectangle.GetCurrentLength();

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void SetNewWidth_Input23_Output23()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 23;

            //Act
            int actual = rectangle.SetNewWidth(23);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewWidth_Input25_Output25()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 25;

            //Act
            int actual = rectangle.SetNewWidth(25);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewWidth_Input101_Output101()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 23;

            //Act
            int actual = rectangle.SetNewWidth(23);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewLength_Input15_Output15()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 15;

            //Act
            int actual = rectangle.SetNewWidth(15);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewLength_Input119_Output119()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 119;

            //Act
            int actual = rectangle.SetNewWidth(119);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void SetNewLength_Input101_Output101()
        {
            Rectangle rectangle = new Rectangle();

            //Arrange
            int expected = 101;

            //Act
            int actual = rectangle.SetNewWidth(101);

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void GetPerimeter_Input10and20_Output60()
        {
            Rectangle rectangle = new Rectangle(10, 20);

            //Arrange
            int expected = 60;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input15and11_Output52()
        {
            Rectangle rectangle = new Rectangle(15, 11);

            //Arrange
            int expected = 52;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetPerimeter_Input105and33_Output276()
        {
            Rectangle rectangle = new Rectangle(105, 33);

            //Arrange
            int expected = 276;

            //Act
            int actual = rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void GetArea_Input4and5_Output20()
        {
            Rectangle rectangle = new Rectangle(4, 5);

            //Arrange
            int expected = 20;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_Input100and300_Output30000()
        {
            Rectangle rectangle = new Rectangle(100, 300);

            //Arrange
            int expected = 30000;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GetArea_Input14and20_Output280()
        {
            Rectangle rectangle = new Rectangle(14, 20);

            //Arrange
            int expected = 280;

            //Act
            int actual = rectangle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
