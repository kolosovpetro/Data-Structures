using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SingleLinkedListTests
{
    [TestFixture]
    public class AddLastTest
    {
        [Test]
        public void Add_Last_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedList<char>();
            linkedList.IsEmpty.Should().BeTrue();
            linkedList.AddLast('A');
            linkedList.First.Value.Should().Be('A');
            linkedList.Last.Value.Should().Be('A');
            linkedList.AddLast('B');
            linkedList.Last.Value.Should().Be('B');
            linkedList.First.Value.Should().Be('A');
            linkedList.Count.Should().Be(2);
        }
    }
}