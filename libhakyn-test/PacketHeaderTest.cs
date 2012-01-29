using libhakyn.Protocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for PacketHeaderTest and is intended
    ///to contain all PacketHeaderTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PacketHeaderTest
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
        ///A test for PacketHeader Constructor
        ///</summary>
        [TestMethod()]
        public void PacketHeaderConstructorTest1()
        {
            byte[] bytes = { 0x48, 0x41, 0x4B, 0x00, 0x00, 0x00, 0x20, 0x00, 0x01 };
            PacketHeader target = new PacketHeader(bytes);
            Assert.AreEqual(32, target.Length);
            Assert.AreEqual(0x01, target.Command);
        }

        /// <summary>
        ///A test for getBytes
        ///</summary>
        [TestMethod()]
        public void getBytesTest()
        {
            byte[] bytes = { 0x48, 0x41, 0x4B, 0x00, 0x00, 0x00, 0x20, 0x00, 0x01 };
            PacketHeader target = new PacketHeader(bytes);
            byte[] expected = { 0x48, 0x41, 0x4B, 0x00, 0x00, 0x00, 0x20, 0x00, 0x01 }; ;
            byte[] actual;
            actual = target.getBytes();
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
    }
}
