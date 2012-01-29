using libhakyn.Command;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace libhakyn_test
{
    
    
    /// <summary>
    ///This is a test class for CommandDelegatesTest and is intended
    ///to contain all CommandDelegatesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommandDelegatesTest
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
        ///A test for CommandDelegates Constructor
        ///</summary>
        [TestMethod()]
        public void CommandDelegatesConstructorTest()
        {
            CommandDelegates target = new CommandDelegates();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CommandInitialized
        ///</summary>
        [TestMethod()]
        public void CommandInitializedTest()
        {
            byte b = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = CommandDelegates.CommandInitialized(b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetSpawnMonsterDelegate
        ///</summary>
        [TestMethod()]
        public void SetSpawnMonsterDelegateTest()
        {
            CommandDelegates.SpawnMonsterDelegate sm = null; // TODO: Initialize to an appropriate value
            CommandDelegates.SetSpawnMonsterDelegate(sm);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetUpdatePositionDelagate
        ///</summary>
        [TestMethod()]
        public void SetUpdatePositionDelagateTest()
        {
            CommandDelegates.UpdatePositionDelegate up = null; // TODO: Initialize to an appropriate value
            CommandDelegates.SetUpdatePositionDelagate(up);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for getInitializedDelegate
        ///</summary>
        [TestMethod()]
        public void getInitializedDelegateTest()
        {
            byte b = 0; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = CommandDelegates.getInitializedDelegate(b);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
