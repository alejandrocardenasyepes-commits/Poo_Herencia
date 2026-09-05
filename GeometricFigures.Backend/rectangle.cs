namespace GeometricFigures.Backend;

 public class rectangle : Square
{
    //fields 

    public double _b;

    //constructor

    public rectangle(string name, double a, double b) : base(name, a)
    {
        validateB(b);
        B = b;
    }

    //properties

    public double B { get; set; }

    //methonds public 

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    public override double GetArea()
    {
        return A * B;
    }

    //methonds private 

    private void validateB(double b)
    {
        if (b <= 0)
        {
            throw new ArgumentException("the b field must be greater than zero.", nameof(b));
        }

    }
}
