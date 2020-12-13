using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequeClearTest
    {
        [Test]
        public void Deque_Clear_Test()
        {
            var deque = new Deque<char>();
            deque.EnqueueFirst('A');
            deque.EnqueueFirst('B');
            deque.EnqueueFirst('C');
            deque.Count.Should().Be(3);
            deque.IsEmpty.Should().BeFalse();
            deque.Clear();
            deque.Count.Should().Be(0);
            deque.IsEmpty.Should().BeTrue();
        }
    }
}