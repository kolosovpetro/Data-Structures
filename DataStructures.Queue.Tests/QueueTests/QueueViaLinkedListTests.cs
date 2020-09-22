using System;
using DataStructures.Queue.Abstractions;
using DataStructures.Queue.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Queue.Tests.QueueTests
{
    [TestFixture]
    public class QueueViaLinkedListTests
    {
        [Test]
        public void Enqueue_Test()
        {
            IQueue<char> queue = new QueueViaLinkedList<char>(5);
            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');
            queue.Enqueue('E');
            queue.IsEmpty.Should().BeFalse();
            queue.IsFull.Should().BeTrue();
            queue.Count.Should().Be(5);
        }

        [Test]
        public void Peek_Test()
        {
            IQueue<char> queue = new QueueViaLinkedList<char>(5);
            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');
            queue.Enqueue('E');
            queue.IsEmpty.Should().BeFalse();
            queue.IsFull.Should().BeTrue();
            queue.Count.Should().Be(5);
            queue.Peek().Should().Be('A');
            queue.Peek().Should().Be('A');
            queue.Peek().Should().Be('A');

            Action act = () => new QueueViaLinkedList<char>(5).Peek();
            act.Should().Throw<IndexOutOfRangeException>()
                .WithMessage("Queue is empty.");
        }

        [Test]
        public void Dequeue_Test()
        {
            IQueue<char> queue = new QueueViaLinkedList<char>(5);
            queue.Enqueue('A');
            queue.Enqueue('B');
            queue.Enqueue('C');
            queue.Enqueue('D');
            queue.Enqueue('E');
            queue.IsEmpty.Should().BeFalse();
            queue.IsFull.Should().BeTrue();
            queue.Count.Should().Be(5);
            queue.Dequeue().Should().Be('A');
            queue.Count.Should().Be(4);
            queue.Dequeue().Should().Be('B');
            queue.Count.Should().Be(3);
            queue.Dequeue().Should().Be('C');
            queue.Count.Should().Be(2);
            queue.Dequeue().Should().Be('D');
            queue.Count.Should().Be(1);
            queue.Dequeue().Should().Be('E');
            queue.Count.Should().Be(0);

            Action act = () => queue.Dequeue();
            act.Should().Throw<IndexOutOfRangeException>()
                .WithMessage("Queue is empty.");
        }
    }
}