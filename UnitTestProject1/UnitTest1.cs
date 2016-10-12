using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using question3try1;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1Working()
        {


            //arrange
            RecordsList r = new RecordsList();
            //act
            string actual = r.AddRecord("UG123456", "Sam", "Moore", DateTime.Parse("01/01/2011"), DateTime.Parse("01/01/2015"));
            //assert
            string expected = "Yaaaay REcord Added";

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestMethodBADStartDate()
        {
            //arrange
            RecordsList r = new RecordsList();

            //act
            string actual = r.AddRecord("UG123456", "Sam", "Moore", DateTime.Parse("01/01/2017"), DateTime.Parse("01/01/2015"));

            string expected = "Not done";

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestMethodBADCourseCode()
        {
            //arrange
            RecordsList r = new RecordsList();

            //act
            string actual = r.AddRecord("XX123456", "Sam", "Moore", DateTime.Parse("01/01/2017"), DateTime.Parse("01/01/2015"));

            string expected = "Not done";

            //assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void TestRegularExpresiongood()
        {
            RecordsList r = new RecordsList();

            string actual = r.Coursecode("UG123456");

            string expected = "expression is good";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestRegularExpresionBad()
        {
            RecordsList r = new RecordsList();

            string actual = r.Coursecode("XX123456");

            string expected = "not good";

            Assert.AreEqual(expected, actual);
        }

    }
}
