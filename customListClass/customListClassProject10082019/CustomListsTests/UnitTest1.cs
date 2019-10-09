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

            //ACT 
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
        public void Add_AddPositiveNumbers()
        {
            //ARRANGE
            CustomGenericList<int> testList = new CustomGenericList<int>();
            double value1 = 1;
            double value2 = 2;
            double result;

            //ACT
            result = testList.Calculate(value1, value2);

            //ASSERT
            Assert.AreEqual(value1 + value2, result);
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
    }
}
            
