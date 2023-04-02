using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShowMeTheMoney;
using System;

namespace UnitTest
{
    [TestClass]
    public class LogicEngineUnitTest
    {
        LogicEngine logicEngine = new LogicEngine();

        [TestMethod]
        public void Chars1()
        {
            //Arrange
            string testValue = "NaN";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars2()
        {
            //Arrange
            string testValue = "$";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars3()
        {
            //Arrange
            string testValue = "¢";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars4()
        {
            //Arrange
            string testValue = "€";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars5()
        {
            //Arrange
            string testValue = "£";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars6()
        {
            //Arrange
            string testValue = "One Hundred Dollars";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Chars7()
        {
            //Arrange
            string testValue = "fdrssdgasdhbdihi.dfssdf8";
            string expected = "Your entry is not valid number! Error message: Input string was not in a correct format.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest1()
        {
            //Arrange
            string testValue = "10001";
            string expected = "The amount entered '10001' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest2()
        {
            //Arrange
            string testValue = "10000";
            string expected = "Ten Thousand Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest3()
        {
            //Arrange
            string testValue = "000.1";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest4()
        {
            //Arrange
            string testValue = "00.1";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest5()
        {
            //Arrange
            string testValue = "25000";
            string expected = "The amount entered '25000' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest6()
        {
            //Arrange
            string testValue = "-1";
            string expected = "The amount entered '-1' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest7()
        {
            //Arrange
            string testValue = "0";
            string expected = "Ooops! - Error message: Index and length must refer to a location within the string.\r\nParameter name: length";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest8()
        {
            //Arrange
            string testValue = "-0";
            string expected = "The amount entered '0' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest9()
        {
            //Arrange
            string testValue = "12345678912345678912345678913";
            string expected = "The amount entered '12345678912345678912345678913' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest10()
        {
            //Arrange
            string testValue = "123456789123456789123456789134";
            string expected = "Ooops! - Error message: Value was either too large or too small for a Decimal.";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest11()
        {
            //Arrange
            string testValue = "-0.1";
            string expected = "The amount entered '-0.1' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest12()
        {
            //Arrange
            string testValue = "-.1";
            string expected = "The amount entered '-0.1' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest13()
        {
            //Arrange
            string testValue = "-0.0";
            string expected = "The amount entered '0.0' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void BoundsTest14()
        {
            //Arrange
            string testValue = "-.0";
            string expected = "The amount entered '0.0' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros1()
        {
            //Arrange
            string testValue = "0001";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros2()
        {
            //Arrange
            string testValue = "000.1";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros3()
        {
            //Arrange
            string testValue = "001";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros4()
        {
            //Arrange
            string testValue = "00.1";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros5()
        {
            //Arrange
            string testValue = "01";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros6()
        {
            //Arrange
            string testValue = "00.100";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros7()
        {
            //Arrange
            string testValue = "001.000";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros8()
        {
            //Arrange
            string testValue = "0";
            string expected = "Ooops! - Error message: Index and length must refer to a location within the string.\r\nParameter name: length";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zero9()
        {
            //Arrange
            string testValue = "-0";
            string expected = "The amount entered '0' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros10()
        {
            //Arrange
            string testValue = "00";
            string expected = "The amount entered can only have 1 leading zero before the decimal point!";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Zeros11()
        {
            //Arrange
            string testValue = "0.000";
            string expected = "The amount entered '0.000' is outside of the limits - 0.01 to 10000";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines1()
        {
            //Arrange
            string testValue = "9999.99";
            string expected = "Nine Thousand Nine Hundred and Ninety Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines2()
        {
            //Arrange
            string testValue = "9099.99";
            string expected = "Nine Thousand and Ninety Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines3()
        {
            //Arrange
            string testValue = "9009.99";
            string expected = "Nine Thousand and Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines4()
        {
            //Arrange
            string testValue = "9000.90";
            string expected = "Nine Thousand Dollars and Ninety Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines5()
        {
            //Arrange
            string testValue = "9000.09";
            string expected = "Nine Thousand Dollars and Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines6()
        {
            //Arrange
            string testValue = "9000.00";
            string expected = "Nine Thousand Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines7()
        {
            //Arrange
            string testValue = "9000.0";
            string expected = "Nine Thousand Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines8()
        {
            //Arrange
            string testValue = "9000.";
            string expected = "Nine Thousand Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines9()
        {
            //Arrange
            string testValue = "9000";
            string expected = "Nine Thousand Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines10()
        {
            //Arrange
            string testValue = "999.99";
            string expected = "Nine Hundred and Ninety Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void Nines11()
        {
            //Arrange
            string testValue = "909.99";
            string expected = "Nine Hundred and Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines12()
        {
            //Arrange
            string testValue = "900.99";
            string expected = "Nine Hundred Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines13()
        {
            //Arrange
            string testValue = "900.90";
            string expected = "Nine Hundred Dollars and Ninety Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines14()
        {
            //Arrange
            string testValue = "900.09";
            string expected = "Nine Hundred Dollars and Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines15()
        {
            //Arrange
            string testValue = "900.00";
            string expected = "Nine Hundred Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines16()
        {
            //Arrange
            string testValue = "900.0";
            string expected = "Nine Hundred Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines17()
        {
            //Arrange
            string testValue = "900.";
            string expected = "Nine Hundred Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void Nines18()
        {
            //Arrange
            string testValue = "900";
            string expected = "Nine Hundred Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines19()
        {
            //Arrange
            string testValue = "99.99";
            string expected = "Ninety Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines20()
        {
            //Arrange
            string testValue = "90.99";
            string expected = "Ninety Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines21()
        {
            //Arrange
            string testValue = "90.09";
            string expected = "Ninety Dollars and Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void Nines22()
        {
            //Arrange
            string testValue = "90.00";
            string expected = "Ninety Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines23()
        {
            //Arrange
            string testValue = "90.0";
            string expected = "Ninety Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines24()
        {
            //Arrange
            string testValue = "90.";
            string expected = "Ninety Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines25()
        {
            //Arrange
            string testValue = "90";
            string expected = "Ninety Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines26()
        {
            //Arrange
            string testValue = "9.99";
            string expected = "Nine Dollars and Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines27()
        {
            //Arrange
            string testValue = "9.09";
            string expected = "Nine Dollars and Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines28()
        {
            //Arrange
            string testValue = "9.00";
            string expected = "Nine Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines29()
        {
            //Arrange
            string testValue = "9.0";
            string expected = "Nine Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines30()
        {
            //Arrange
            string testValue = "9.";
            string expected = "Nine Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines31()
        {
            //Arrange
            string testValue = "0.99";
            string expected = "Ninety Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines32()
        {
            //Arrange
            string testValue = "0.90";
            string expected = "Ninety Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines33()
        {
            //Arrange
            string testValue = "0.9";
            string expected = "Ninety Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines34()
        {
            //Arrange
            string testValue = ".9";
            string expected = "Ninety Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines35()
        {
            //Arrange
            string testValue = "0.09";
            string expected = "Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Nines36()
        {
            //Arrange
            string testValue = ".09";
            string expected = "Nine Cents";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens1()
        {
            //Arrange
            string testValue = "10";
            string expected = "Ten Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens2()
        {
            //Arrange
            string testValue = "11";
            string expected = "Eleven Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens3()
        {
            //Arrange
            string testValue = "12";
            string expected = "Tweleve Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens4()
        {
            //Arrange
            string testValue = "13";
            string expected = "Thirteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens5()
        {
            //Arrange
            string testValue = "14";
            string expected = "Fourteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens6()
        {
            //Arrange
            string testValue = "15";
            string expected = "Fifteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens7()
        {
            //Arrange
            string testValue = "16";
            string expected = "Sixteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }
        [TestMethod]
        public void Teens8()
        {
            //Arrange
            string testValue = "17";
            string expected = "Seventeen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens9()
        {
            //Arrange
            string testValue = "18";
            string expected = "Eighteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Teens10()
        {
            //Arrange
            string testValue = "19";
            string expected = "Nineteen Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs1()
        {
            //Arrange
            string testValue = "20";
            string expected = "Twenty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs2()
        {
            //Arrange
            string testValue = "30";
            string expected = "Thirty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs3()
        {
            //Arrange
            string testValue = "40";
            string expected = "Forty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs4()
        {
            //Arrange
            string testValue = "50";
            string expected = "Fifty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs5()
        {
            //Arrange
            string testValue = "60";
            string expected = "Sixty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs6()
        {
            //Arrange
            string testValue = "70";
            string expected = "Seventy Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Decs7()
        {
            //Arrange
            string testValue = "80";
            string expected = "Eighty Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }


        [TestMethod]
        public void Decs8()
        {
            //Arrange
            string testValue = "90";
            string expected = "Ninety Dollars";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles1()
        {
            //Arrange
            string testValue = "1.01";
            string expected = "One Dollar and One Cent";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles2()
        {
            //Arrange
            string testValue = "1.00";
            string expected = "One Dollar";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles3()
        {
            //Arrange
            string testValue = "1.0";
            string expected = "One Dollar";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles4()
        {
            //Arrange
            string testValue = "1";
            string expected = "One Dollar";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles5()
        {
            //Arrange
            string testValue = "0.01";
            string expected = "One Cent";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }

        [TestMethod]
        public void Singles6()
        {
            //Arrange
            string testValue = ".01";
            string expected = "One Cent";

            //Act
            string response = logicEngine.ResponseBuilder(testValue);

            //Assert
            Assert.AreEqual(response, expected);
        }
    }
}
