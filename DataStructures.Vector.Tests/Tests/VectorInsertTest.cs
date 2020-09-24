using DataStructures.Vector.Abstractions;
using DataStructures.Vector.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Vector.Tests.Tests
{
    [TestFixture]
    public class VectorInsertTest
    {
        [Test]
        public void Vector_Insert_Test()
        {
            IVector<int> vector = new Vector<int>();
            vector.Push(1);
            vector.Push(2);
            // insert 7 here
            vector.Push(3);
            vector.Push(4);
            vector.Push(5);

            vector.Capacity.Should().Be(8);
            vector.Insert(2, 7);
            vector.Capacity.Should().Be(8);
            vector.Count.Should().Be(6);

            vector.ElementAt(0).Should().Be(1);
            vector.ElementAt(1).Should().Be(2);
            vector.ElementAt(2).Should().Be(7);
            vector.ElementAt(3).Should().Be(3);
            vector.ElementAt(4).Should().Be(4);
            vector.ElementAt(5).Should().Be(5);
            
            vector.Insert(7, 9);
            vector.ElementAt(0).Should().Be(1);
            vector.ElementAt(1).Should().Be(2);
            vector.ElementAt(2).Should().Be(7);
            vector.ElementAt(3).Should().Be(3);
            vector.ElementAt(4).Should().Be(4);
            vector.ElementAt(5).Should().Be(5);
            vector.ElementAt(6).Should().Be(0);
            vector.ElementAt(7).Should().Be(9);
        }
    }
}