using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InterfacesAndTestability.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}


/*
 Note that each test class as an attribute called Test class and it can have a bunch of methods like

the one you see here which are decorated with test method attributes in C-sharp attributes represent

meta data about your classes and their members.

They don't have any logic there are just markers.

Then another application or another assembly can read this method data and do something about it.

For example later you're going to see that we're going to use Microsoft test runner and that test runner

 */