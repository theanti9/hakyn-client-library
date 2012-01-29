using libhakyn.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for ArrayUtilTest and is intended
    ///to contain all ArrayUtilTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ArrayUtilTest
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
        ///A test for ByteSubArray
        ///</summary>
        [TestMethod()]
        public void ByteSubArrayTest()
        {
            // Initialize simple byte array
            byte[] data = { 0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0x0E, 0x0F };
            
            // Test starting from 0
            int index = 0; 
            int length = 3; 
            byte[] expected = { 0x00, 0x01, 0x02 };
            byte[] actual = ArrayUtil.ByteSubArray(data, index, length);
            Assert.IsTrue(expected.SequenceEqual(actual));

            index = 4; // Start from 4
            length = 5; // Get 5
            expected = new byte[5]{ 0x04, 0x05, 0x06, 0x07, 0x08 };
            actual = ArrayUtil.ByteSubArray(data, index, length);
            Assert.IsTrue(expected.SequenceEqual(actual));

        }

        /// <summary>
        ///A test for StringToBytes
        ///</summary>
        [TestMethod()]
        public void StringToBytesTest()
        {
            // Try out our packet header
            string str = "HAK";
            byte[] expected = { 0x48, 0x41, 0x4B };
            byte[] actual;
            actual = ArrayUtil.StringToBytes(str);

            Assert.IsTrue(expected.SequenceEqual(actual));
            
        }
    }
}
