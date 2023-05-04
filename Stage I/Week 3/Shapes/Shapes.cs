namespace ShapesApp
{
    class Shapes
    {
        public double ShapeHeight { get; set; }

        public double ShapeLength { get; set; }

        public string ShapeColor { get; set; }

        public Shapes()
        {
            ShapeHeight = 0;
            ShapeLength = 0;
        }

        public Shapes(double height, double length)
        {
            ShapeHeight = height;
            ShapeLength = length;
        }

        public override string ToString()
        {
            return "The height is " + ShapeHeight + " the length is " + ShapeLength;
        }
    } // end class
} // end namespace