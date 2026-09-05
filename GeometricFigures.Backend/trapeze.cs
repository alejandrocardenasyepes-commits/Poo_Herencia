namespace GeometricFigures.Backend;

public class Trapeze : Triangle
{

    //fields 

    public double _d;

    //constructor
    public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
    {
        validateD(d);
        D = d;
    }


    //properties

    public double D { get; set; }

    //methonds public 

    public override double GetPerimeter()
    {
        return A + B + C + D;
    }

    public override double GetArea()
    {
        return (B + D) * H / 2;
    }

    //methonds private 

    private void validateD(double d)
    {
        if (d <= 0)
        {
            throw new ArgumentException("the d field must be greater than zero.", nameof(d));
        }
    }
}
