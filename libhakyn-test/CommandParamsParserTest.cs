using libhakyn.Command.DelegateUtil;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for CommandParamsParserTest and is intended
    ///to contain all CommandParamsParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommandParamsParserTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for parseBytes
        ///</summary>
        [TestMethod()]
        public void parseBytesTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            byte command = 0; // TODO: Initialize to an appropriate value
            List<object> expected = null; // TODO: Initialize to an appropriate value
            List<object> actual;
            actual = CommandParamsParser.parseBytes(bytes, command);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
