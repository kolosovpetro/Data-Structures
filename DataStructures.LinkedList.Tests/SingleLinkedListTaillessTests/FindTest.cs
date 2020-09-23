using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SingleLinkedListTaillessTests
{
    [TestFixture]
    public class FindTest
    {
        [Test]
        public void Find_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedListTailless<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');

            linkedList.Find('B').Value.Should().Be('B');
            linkedList.Find('E').Should().BeNull();
        }
    }
}