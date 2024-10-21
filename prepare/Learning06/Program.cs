class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes= new List<Shape>();
        shapes.Add(new Square(4, "red"));
        shapes.Add(new Rectangle(2, 3, "blue"));
        shapes.Add(new Circle(2, "yellow"));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
        }
    }
}