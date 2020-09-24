using DataStructures.Vector.Abstractions;
using DataStructures.Vector.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Vector.Tests.Tests
{
    [TestFixture]
    public class VectorDeleteAtTest
    {
        [Test]
        public void Vector_Delete_At_Test()
        {
            IVector<int> vector = new Vector<int>();
            vector.Push(1);
            vector.Push(2);
            vector.Push(3);
            vector.Push(4);
            vector.Push(5);

            vector.Capacity.Should().Be(8);
            vector.ElementAt(0).Should().Be(1);
            vector.ElementAt(1).Should().Be(2);
            vector.ElementAt(2).Should().Be(3);
            vector.ElementAt(3).Should().Be(4);
            vector.ElementAt(4).Should().Be(5);

            vector.DeleteAt(2);    // deletes 3
            vector.Capacity.Should().Be(4);
            vector.ElementAt(0).Should().Be(1);
            vector.ElementAt(1).Should().Be(2);
            vector.ElementAt(2).Should().Be(4);
            vector.ElementAt(3).Should().Be(5);
        }
    }
}