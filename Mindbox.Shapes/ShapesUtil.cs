namespace Mindbox.Shapes
{
    public static class ShapesUtil
    {
        public static double GetTriangleArea(double a, double b, double c) =>
            new Triangle(a, b, c).Area;

        public static double GetCircleArea(double r) =>
            new Circle(r).Area;
    }
}
