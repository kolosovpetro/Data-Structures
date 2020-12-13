using DataStructures.Deque.Implementations;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Deque.Tests.Tests
{
    [TestFixture]
    public class DequeContainsTest
    {
        [Test]
        public void Deque_Contains_Test()
        {
            var deque = new Deque<string>();
            deque.EnqueueFirst("string 1");
            deque.EnqueueLast("string 2");
            deque.EnqueueLast("string 3");
            deque.EnqueueFirst("string 4");
            deque.Contains("string 1").Should().BeTrue();
            deque.Contains("string 2").Should().BeTrue();
            deque.Contains("string 3").Should().BeTrue();
            deque.Contains("string 4").Should().BeTrue();
            deque.Contains("string 5").Should().BeFalse();
        }
    }
}