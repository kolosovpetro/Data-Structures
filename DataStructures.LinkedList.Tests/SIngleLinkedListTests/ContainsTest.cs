using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SIngleLinkedListTests
{
    [TestFixture]
    public class ContainsTest
    {
        [Test]
        public void Contains_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedList<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');
            linkedList.First.Value.Should().Be('D');
            linkedList.Count.Should().Be(4);
            linkedList.Contains('A').Should().BeTrue();
            linkedList.Contains('C').Should().BeTrue();
            linkedList.Contains('D').Should().BeTrue();
            linkedList.Contains('E').Should().BeFalse();
        }
    }
}