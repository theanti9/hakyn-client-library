using libhakyn.Protocol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for PacketTest and is intended
    ///to contain all PacketTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PacketTest
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
        ///A test for Packet Constructor
        ///</summary>
        [TestMethod()]
        public void PacketConstructorTest()
        {
            PacketHeader header = new PacketHeader(32, 0x01);
            byte[] body = new byte[32] { 0x48, 0x41, 0x4B,
                                         0x48, 0x41, 0x4B,
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x00, 0x00, 0x00, 0x01,
                                         0x00, 0x00, 0x00, 0x01 };
            Packet target = new Packet(header, body);
            Assert.IsTrue(body.SequenceEqual(target.Body));
            Assert.IsTrue(header.Equals(target.Header));
        }

        /// <summary>
        ///A test for Packet Constructor
        ///</summary>
        [TestMethod()]
        public void PacketConstructorTest1()
        {
            byte[] bytes = new byte[41] {0x48, 0x41, 0x4B,
                                         0x00, 0x00, 0x00, 0x20,
                                         0x00, 0x01,
                                         0x48, 0x41, 0x4B,
                                         0x48, 0x41, 0x4B,
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x48, 0x41, 0x4B, 
                                         0x00, 0x00, 0x00, 0x01,
                                         0x00, 0x00, 0x00, 0x01 };
            Packet target = new Packet(bytes);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for getBytes
        ///</summary>
        [TestMethod()]
        public void getBytesTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            Packet target = new Packet(bytes); // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            actual = target.getBytes();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
