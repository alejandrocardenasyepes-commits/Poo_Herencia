namespace GeometricFigures.Backend;

public class Square : GeometricFigure
{

    // fields 

    public double _a;


    //constructor

    public Square(string name, double a) : base(name)
    {
        validateA(a);
        A = a;
    }

    //properties
    public double A { get; set; }


    //methonds public


    public override double GetArea()
    {
        return A * A;
    }

    public override double Getperimeter()
    {
        return A * 4;
    }

    //methonds private 

    private double validateA(double a) 
    {
        if (a <= 0) 
        {
            throw new ArgumentException("the side must be greater than zero", nameof(a));
        }

        return a;
    }

}
