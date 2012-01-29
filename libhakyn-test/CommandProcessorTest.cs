using libhakyn.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for CommandProcessorTest and is intended
    ///to contain all CommandProcessorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommandProcessorTest
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
        ///A test for CommandProcessor Constructor
        ///</summary>
        [TestMethod()]
        public void CommandProcessorConstructorTest()
        {
            CommandProcessor target = new CommandProcessor();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for enqueue
        ///</summary>
        [TestMethod()]
        public void enqueueTest()
        {
            byte[] bytes = null; // TODO: Initialize to an appropriate value
            CommandProcessor.enqueue(bytes);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for process
        ///</summary>
        [TestMethod()]
        [DeploymentItem("libhakyn.dll")]
        public void processTest()
        {
            CommandProcessor_Accessor.process();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for setup
        ///</summary>
        [TestMethod()]
        public void setupTest()
        {
            CommandProcessor.setup();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
