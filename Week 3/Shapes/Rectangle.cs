namespace ShapesApp
{
    class Rectangle : Shapes
    {
        public double RectangleArea;

        public Rectangle(double height, double length) : base(height, length)
        {

        }

        public double GetArea()
        {
            return ShapeHeight * ShapeLength;
        }

        public double Area => ShapeHeight * ShapeLength;


        public override string ToString()
        {
            return base.ToString() + ", the area is " + RectangleArea;
        }

    } // end class
}// end namespace