using DataStructures.Vector.Abstractions;
using DataStructures.Vector.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Vector.Tests.Tests
{
    [TestFixture]
    public class VectorInitializationTest
    {
        [Test]
        public void Vector_Initialization_Test()
        {
            IVector<int> vector = new Vector<int>();
            vector.Capacity.Should().Be(2);
            vector.Count.Should().Be(0);
            vector.IsEmpty.Should().BeTrue();
        }
    }
}