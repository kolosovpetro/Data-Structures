using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequeAddLastTest
    {
        [Test]
        public void Dequeue_Add_Last_Test()
        {
            var deque = new Deque<string>();
            deque.EnqueueLast("string 1");
            deque.EnqueueLast("string 2");
            deque.EnqueueLast("string 3");
            deque.Count.Should().Be(3);
            deque.PeekFirst().Value.Should().Be("string 1");
            deque.PeekFirst().Next?.Value.Should().Be("string 2");
            deque.PeekFirst().Next?.Next?.Value.Should().Be("string 3");
        }
    }
}