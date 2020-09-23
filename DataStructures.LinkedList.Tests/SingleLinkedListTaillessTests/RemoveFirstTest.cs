using System;
using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SingleLinkedListTaillessTests
{
    [TestFixture]
    public class RemoveFirstTest
    {
        [Test]
        public void Remove_First_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedListTailless<char>();
            var a = linkedList.AddFirst('A');
            var b = linkedList.AddFirst('B');
            var c = linkedList.AddFirst('C');
            var d = linkedList.AddFirst('D');
            linkedList.RemoveFirst();
            d.Next.Should().BeNull();
            linkedList.First.Value.Should().Be('C');
            linkedList.Count.Should().Be(3);
            linkedList.RemoveFirst();
            c.Next.Should().BeNull();
            linkedList.First.Value.Should().Be('B');
            linkedList.Count.Should().Be(2);
            linkedList.RemoveFirst();
            b.Next.Should().BeNull();
            linkedList.First.Value.Should().Be('A');
            linkedList.Count.Should().Be(1);
            linkedList.RemoveFirst();
            a.Next.Should().BeNull();
            linkedList.First.Should().BeNull();
            linkedList.IsEmpty.Should().BeTrue();

            Action act = () => linkedList.RemoveFirst();
            act.Should().Throw<IndexOutOfRangeException>()
                .WithMessage("Linked list is empty.");
        }
    }
}