using Mindbox.Shapes;
using NUnit.Framework;

namespace Mindbox.ShapesTests
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCase(-1.0, 1.0, 1.0)]
        [TestCase(1.0, -1.0, 1.0)]
        [TestCase(1.0, 1.0, -1.0)]
        public void NegativeSide(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [TestCase(0.0, 1.0, 1.0)]
        [TestCase(1.0, 0.0, 1.0)]
        [TestCase(1.0, 1.0, 0.0)]
        public void ZeroSide(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void WrongSides()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(4, 5, 9));
        }

        [TestCase(3.0, 4.0, 5.0, 6.0)]
        [TestCase(2.0, 2.0, 2.0, 1.732051)]
        public void Area(double a, double b, double c, double area)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(area, triangle.Area, 1e-6);
        }

        [Test]
        public void IsRight()
        {
            Assert.IsTrue(new Triangle(3.0, 4.0, 5.0).IsRight());
        }

        [Test]
        public void IsNotRight()
        {
            Assert.IsFalse(new Triangle(1.0, 1.0, 1.0).IsRight());
        }
    }
}