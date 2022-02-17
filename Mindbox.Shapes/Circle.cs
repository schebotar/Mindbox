namespace Mindbox.Shapes
{
    public class Circle : Shape
    {
        private readonly double _radius;
        public double Radius { get => _radius; }

        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Radius should be positive number");
            }

            _radius = radius;
        }

        protected override double GetArea()
        {
            _area = Math.PI * _radius * _radius;
            return _area.Value;
        }
    }
}