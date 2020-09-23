using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SIngleLinkedListTests
{
    [TestFixture]
    public class AddFirstTest
    {
        [Test]
        public void Add_First_Simple_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedListTailless<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');
            linkedList.First.Value.Should().Be('D');
            linkedList.Count.Should().Be(4);
            d.Next.Value.Should().Be('C');
            c.Next.Value.Should().Be('B');
            b.Next.Value.Should().Be('A');
            a.Next.Should().BeNull();
        }
    }
}