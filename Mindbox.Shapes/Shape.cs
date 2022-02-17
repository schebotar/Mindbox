namespace Mindbox.Shapes
{
    public abstract class Shape
    {
        protected double? _area;

        public double Area
        {
            get
            {
                return _area ?? GetArea();
            }
        }

        protected abstract double GetArea();
    }
}