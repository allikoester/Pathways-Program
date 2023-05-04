namespace ShapesApp
{
    class Triangle : Shapes
    {
        private double TriangleArea;

        private double TrianglePerimeter;

        public Triangle(double height, double length, double sideA, double sideB) : base(height, length)
        {
            TrianglePerimeter = sideA + sideB + ShapeLength;
            TriangleArea = (ShapeHeight * ShapeLength) / 2;
        }

        public double GetArea()
        {
            return TriangleArea;
        }

        public double GetPerimeter()
        {
            return TrianglePerimeter;
        }

        public override string ToString()
        {
            return base.ToString() + ", the area is " + TriangleArea + ", the perimeter is " + TrianglePerimeter;
        }
    } // end class
} // end namespace