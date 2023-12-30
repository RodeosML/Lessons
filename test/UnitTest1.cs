using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmsDataStructures;

namespace AlgorithmsDataStructures
{

    [TestClass]
    public class StackTests
    {
        
        [TestMethod]
        public void EnqueueShouldItemAddedCountIncreases()
        {
            Queue<int> queue = new Queue<int>();

            queue.Enqueue(100);

            Assert.AreEqual(1, queue.Size());
        }

        [TestMethod]
        public void DequeueShouldItemRemovedCountDecreases()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);

            queue.Dequeue();
            queue.Dequeue();

            Assert.AreEqual(0, queue.Size());
        }

        [TestMethod]
        public void DequeueShouldQueueEmptyReturnsDefault()
        {
            Queue<int> queue = new Queue<int>();

            int result = queue.Dequeue();

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void SizeShouldQueueReturnsZero()
        {
            Queue<int> queue = new Queue<int>();

            int size = queue.Size();

            Assert.AreEqual(0, size);
        }

        [TestMethod]
        public void SizeShouldItemsAddedReturnsCorrectSize()
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(5);
            queue.Enqueue(10);

            int size = queue.Size();

            Assert.AreEqual(2, size);
        }
    }
}
