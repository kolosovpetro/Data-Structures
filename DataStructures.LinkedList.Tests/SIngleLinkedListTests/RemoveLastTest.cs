using System;
using DataStructures.LinkedList.Abstractions;
using DataStructures.LinkedList.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.LinkedList.Tests.SingleLinkedListTests
{
    [TestFixture]
    public class RemoveLastTest
    {
        [Test]
        public void Remove_Last_Test()
        {
            ILinkedList<char> linkedList = new SingleLinkedList<char>();
            linkedList.AddFirst('A');
            linkedList.AddFirst('B');
            linkedList.AddFirst('C');
            linkedList.AddFirst('D');
            linkedList.First.Value.Should().Be('D');
            linkedList.Count.Should().Be(4);
            linkedList.Last.Value.Should().Be('A');

            linkedList.RemoveLast();
            linkedList.Last.Value.Should().Be('B');
            linkedList.Count.Should().Be(3);
            linkedList.RemoveLast();
            linkedList.Last.Value.Should().Be('C');
            linkedList.Count.Should().Be(2);
            linkedList.RemoveLast();
            linkedList.Last.Value.Should().Be('D');
            linkedList.Count.Should().Be(1);
            linkedList.RemoveLast();
            linkedList.Last.Should().BeNull();
            linkedList.First.Should().BeNull();
            linkedList.Count.Should().Be(0);
            linkedList.IsEmpty.Should().BeTrue();

            Action act = () => linkedList.RemoveLast();
            act.Should().Throw<IndexOutOfRangeException>()
                .WithMessage("Linked list is empty.");
        }
    }
}