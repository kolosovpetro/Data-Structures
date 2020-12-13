using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequeAddFirstTest
    {
        [Test]
        public void Deque_Add_First_Test()
        {
            var deque = new Deque<string>();
            deque.EnqueueFirst("string 1");
            deque.EnqueueFirst("string 2");
            deque.EnqueueFirst("string 3");
            deque.Count.Should().Be(3);
            deque.PeekFirst().Value.Should().Be("string 3");
            deque.PeekFirst().Next?.Value.Should().Be("string 2");
            deque.PeekFirst().Next?.Next?.Value.Should().Be("string 1");
        }
    }
}