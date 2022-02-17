namespace Mindbox.Shapes
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;
        public double SideA { get => _sideA; }
        public double SideB { get => _sideB; }
        public double SideC { get => _sideC; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Side should be positive number");
            }

            if (sideA + sideB <= sideC || sideB + sideC <= sideA || sideA + sideC <= sideB)
            {
                throw new ArgumentException("Triangle is not possible");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        protected override double GetArea()
        {
            double semiPerimeter = (_sideA + _sideB + _sideC) / 2;
            _area = Math.Sqrt(semiPerimeter *
                (semiPerimeter - _sideA) *
                (semiPerimeter - _sideB) *
                (semiPerimeter - _sideC));

            return _area.Value;
        }

        public bool IsRight()
        {
            double[] sides = new[] { _sideA, _sideB, _sideC };
            Array.Sort(sides);

            double hypotenuse = sides[2];
            double[] catheti = new[] { sides[0], sides[1] };

            return hypotenuse * hypotenuse == catheti.Sum(x => x * x);
        }
    }
}
