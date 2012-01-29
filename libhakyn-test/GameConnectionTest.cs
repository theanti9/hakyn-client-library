using libhakyn.Connection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for GameConnectionTest and is intended
    ///to contain all GameConnectionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameConnectionTest
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
        ///A test for GameConnection Constructor
        ///</summary>
        [TestMethod()]
        public void GameConnectionConstructorTest()
        {
            string host = string.Empty; // TODO: Initialize to an appropriate value
            int port = 0; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            GameConnection target = new GameConnection(host, port, token);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Start
        ///</summary>
        [TestMethod()]
        public void StartTest()
        {
            string host = string.Empty; // TODO: Initialize to an appropriate value
            int port = 0; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            GameConnection target = new GameConnection(host, port, token); // TODO: Initialize to an appropriate value
            target.Start();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for Write
        ///</summary>
        [TestMethod()]
        public void WriteTest()
        {
            string host = string.Empty; // TODO: Initialize to an appropriate value
            int port = 0; // TODO: Initialize to an appropriate value
            string token = string.Empty; // TODO: Initialize to an appropriate value
            GameConnection target = new GameConnection(host, port, token); // TODO: Initialize to an appropriate value
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            target.Write(bytes);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for handleIncoming
        ///</summary>
        [TestMethod()]
        [DeploymentItem("libhakyn.dll")]
        public void handleIncomingTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            GameConnection_Accessor target = new GameConnection_Accessor(param0); // TODO: Initialize to an appropriate value
            target.handleIncoming();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for handleOutgoing
        ///</summary>
        [TestMethod()]
        [DeploymentItem("libhakyn.dll")]
        public void handleOutgoingTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            GameConnection_Accessor target = new GameConnection_Accessor(param0); // TODO: Initialize to an appropriate value
            target.handleOutgoing();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
