using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using customListClassProject10082019;

namespace CustomListsTests
{
    [TestClass]
    public class CustomListUnitTests
    {
        //ADD unit testing below

        //ARRANGE - setting up variables
        //ACT - actual method we're calling
        //ASSERT - what we're testing
    
        [TestMethod]
        public void Add_AddToEmptyList_ItemGoesToIndexZero()
        {
            //ARRANGE
            CustomGenericList<int> testList = new CustomGenericList<int>();
            int expected = 12;
            int actual;

            ////ACT 
            testList.Add(12);
            actual = testList[0];

            //ASSERT 
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddItemToList_CountIncrements()
        {
            //ARRANGE
            CustomGenericList<int> testList = new CustomGenericList<int>();
            int expected = 1;
            int actual;

            //ACT
            testList.Add(25);
            actual = testList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddMultipleItems_AccessLastItem()
        {
            //ARRANGE
            CustomGenericList<int> testList = new CustomGenericList<int>();
            int expected = 5;
            int actual;

            //ACT
            for (int i = 0; i < 5; i++)
            {
                testList.Add(5);
            }

            actual = testList.Count;

            //ASSERT
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_somethingSomething()
        {
            //ARRANGE
            CustomGenericList<int> testList = new CustomGenericList<int>();
            int expected = 14;
            int actual;

            ////ACT 
            testList.Add(10);
            testList.Add(11);
            testList.Add(12);
            testList.Add(13);
            testList.Add(14);
            actual = testList[4];

            //ASSERT 
            Assert.AreEqual(expected, actual);
        }
    }
}
            
