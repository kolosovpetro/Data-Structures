using DataStructures.Vector.Abstractions;
using DataStructures.Vector.Concrete;
using FluentAssertions;
using NUnit.Framework;

namespace DataStructures.Vector.Tests.Tests
{
    [TestFixture]
    public class VectorPrependTest
    {
        [Test]
        public void Vector_Prepend_Test()
        {
            IVector<int> vector = new Vector<int>();
            vector.Push(1);
            vector.Push(2);
            vector.Push(3);
            
            vector.Prepend(25);
            vector.ElementAt(0).Should().Be(25);
            vector.ElementAt(1).Should().Be(1);
            vector.ElementAt(2).Should().Be(2);
            vector.ElementAt(3).Should().Be(3);
        }
    }
}