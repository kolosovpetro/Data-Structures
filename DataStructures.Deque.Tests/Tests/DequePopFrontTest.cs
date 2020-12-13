using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequePopFrontTest
    {
        [Test]
        public void Deque_Dequeue_Front_Test()
        {
            var deque = new Deque<string>();
            deque.EnqueueLast("string 1");
            deque.EnqueueLast("string 2");
            deque.EnqueueLast("string 3");
            deque.Count.Should().Be(3);
            var t = deque.DequeueFirst();
            t.Value.Should().Be("string 1");
            deque.Count.Should().Be(2);
            deque.PeekFirst().Value.Should().Be("string 2");
            deque.PeekFirst().Next?.Value.Should().Be("string 3");
        }
    }
}