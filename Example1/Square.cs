namespace Example1
{
    public class Square : Figure
    {
        public double Width { get; set; }

        public double Height { get; set; }
        
        public Square(string title) : base(title)
        {
        }

        public Square(string title,
            double width,
            double height) : base(title)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            Area = Height * Width;

            return base.GetArea();
        }
        
    }
}