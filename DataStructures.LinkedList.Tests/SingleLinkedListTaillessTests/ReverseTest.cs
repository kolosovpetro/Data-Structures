using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SingleLinkedListTaillessTests
{
    [TestFixture]
    public class ReverseTest
    {
        [Test]
        public void Reverse_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedListTailless<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');
            linkedList.Reverse();
            linkedList.First.Value.Should().Be('A');
            linkedList.First.Next.Value.Should().Be('B');
            linkedList.First.Next.Next.Value.Should().Be('C');
            linkedList.First.Next.Next.Next.Value.Should().Be('D');

        }
    }
}