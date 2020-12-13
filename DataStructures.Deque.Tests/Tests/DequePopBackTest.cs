using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequePopBackTest
    {
        [Test]
        public void Deque_Pop_Back_Test()
        {
            var deque = new Deque<string>();
            deque.EnqueueLast("string 1");
            deque.EnqueueLast("string 2");
            deque.EnqueueLast("string 3");
            deque.Count.Should().Be(3);
            var t = deque.DequeueLast();
            t.Value.Should().Be("string 3");
            deque.Count.Should().Be(2);
            deque.PeekFirst().Value.Should().Be("string 1");
            deque.PeekFirst().Next?.Value.Should().Be("string 2");
        }
    }
}