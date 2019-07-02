using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Calculator
{
     [TestFixture]
     class Calc2
    {
        [Test]
        public void GetAddition_Input16and30_Return46()
        {
            //Arrange
            double Value1 = 16;
            double Value2 = 30;

            double expectedResult = Value1 + Value2;

            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act
            double actualResult = testCalc1.GetAddition();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input15point4and23point3_Return38point7()
        {
            //Arrange

            double Value1 = 15.4;
            double Value2 = 23.3;

            double expectedResult = Value1 + Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act
            double actualResult = testCalc1.GetAddition();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
            public void GetAddition_Input225and425_Return650()
        {
            //Arrange

            double Value1 = 225;
            double Value2 = 425;

            double expectedResult = Value1 + Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetAddition();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetSubtraction_Input68and22_Return46()
        {
            //Arrange

            double Value1 = 68;
            double Value2 = 22;
            double expectedResult = Value1 - Value2;

            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input24point8and12point4_Return12point4()
        {
            //Arrange

            double Value1 = 24.8;
            double Value2 = 12.4;

            double expectedResult = Value1 - Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input88and33_Return55()
        {
            //Arrange

            double Value1 = 88;
            double Value2 = 33;

            double expectedResult = Value1 - Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetSubtraction();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input24and4_Return96()
        {
            //Arrange

            double Value1 = 24;
            double Value2 = 4;

            double expectedResult = Value1 * Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input4point4and2_Return8point8()
        {
            //Arrange

            double Value1 = 4.4;
            double Value2 = 2;

            double expectedResult = Value1 * Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input40and250_Return10000()
        {
            //Arrange

            double Value1 = 40;
            double Value2 = 250;

            double expectedResult = Value1 * Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetMultiplication();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input120and8_Return15()
        {
            //Arrange

            double Value1 = 120;
            double Value2 = 8;

            double expectedResult = Value1 / Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input2250and90_Return25()
        {
            //Arrange

            double Value1 = 2250;
            double Value2 = 90;

            double expectedResult = Value1 / Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input26point8and2_Return13point4()
        {
            //Arrange

            double Value1 = 26.8;
            double Value2 = 2;

            double expectedResult = Value1 / Value2;
            Calc1 testCalc1 = new Calc1(Value1, Value2);

            //Act

            double actualResult = testCalc1.GetDivision();

            //Assert

            Assert.AreEqual(expectedResult, actualResult);
        }






    }
}
