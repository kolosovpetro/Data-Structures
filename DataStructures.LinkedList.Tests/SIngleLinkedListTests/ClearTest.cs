using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SIngleLinkedListTests
{
    [TestFixture]
    public class ClearTest
    {
        [Test]
        public void Clear_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedListTailless<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');
            linkedList.Clear();
            linkedList.First.Should().BeNull();
            linkedList.Count.Should().Be(0);
            linkedList.IsEmpty.Should().BeTrue();
        }
    }
}