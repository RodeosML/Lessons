using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AlgorithmsDataStructures
{
    
        [TestClass]
        public class DynArrayTests
        {
            [TestMethod]
            public void Insert_ShouldInsertItemAtSpecifiedIndex()
            {
                DynArray<int> checkDynArray = new DynArray<int>();
                checkDynArray.Append(1);
                checkDynArray.Append(2);
                checkDynArray.Append(3);

                checkDynArray.Insert(10, 1);

                Assert.AreEqual(1, checkDynArray.GetItem(0));
                Assert.AreEqual(10, checkDynArray.GetItem(1));
                Assert.AreEqual(2, checkDynArray.GetItem(2));
                Assert.AreEqual(3, checkDynArray.GetItem(3));
            }

            [TestMethod]
            [ExpectedException(typeof(System.IndexOutOfRangeException))]
            public void Insert_ShouldThrowException_WhenIndexIsOutOfRange()
            {
                DynArray<int> checkDynArray = new DynArray<int>();

                checkDynArray.Insert(10, 5);
            }

            [TestMethod]
            public void Remove_ShouldRemoveItemAtSpecifiedIndex()
            {
                DynArray<int> checkDynArray = new DynArray<int>();
                checkDynArray.Append(5);
                checkDynArray.Append(10);
                checkDynArray.Append(25);
                
                checkDynArray.Remove(10);

                Assert.AreEqual(5, checkDynArray.GetItem(0));
                Assert.AreEqual(25, checkDynArray.GetItem(1));
            }

            [TestMethod]
            [ExpectedException(typeof(System.IndexOutOfRangeException))]
            public void Remove_ShouldThrowException_WhenIndexIsOutOfRange()
            {
                
                DynArray<int> checkDynArray = new DynArray<int>();

                checkDynArray.Remove(0);
            }
        }
}
