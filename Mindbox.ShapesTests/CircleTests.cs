using Mindbox.Shapes;
using NUnit.Framework;

namespace Mindbox.ShapesTests
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        public void NegativeRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(-1.0));
        }

        [Test]
        public void ZeroRadius()
        {
            Assert.Throws<ArgumentException>(() => new Circle(0.0));
        }

        [TestCase(7.0, 153.93804)]
        [TestCase(15.0, 706.858347)]
        public void Area(double radius, double area)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(area, circle.Area, 1e-6);
        }
    }
}