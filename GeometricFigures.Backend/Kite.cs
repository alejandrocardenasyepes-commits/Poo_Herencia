namespace GeometricFigures.Backend;

public class Kite : Rhombus
{
    //fields

    public double _b;


    //constructor

    public Kite(string name, double a, double b, double d1, double d2) : base(name, a, d1, d2)
    {
        validateB(b);
        B = b;
    }


    //properties 

    public double B { get; }


    //methonds public 


    public override double Getperimeter()
    {
        return 2 * (A + B);
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
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
