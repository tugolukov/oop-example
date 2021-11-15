namespace Example1
{
    public class Figure
    {
        private protected double Area;

        public string Title { get; set; }
        
        public Figure(string title)
        {
            Title = title;
            Area = 0;
        }

        public virtual double GetArea()
        {
            return Area;
        }

        public override string ToString()
        {
            return $"{Title}: {Area}";
        }
    }
}