namespace GeometricFigures.Backend;

public class circle : GeometricFigure
{

    // fields 

    private double _r;


    //constructor

    public circle(double r, string name) : base("circle")
    {
        validateR(r);
        R = r;
    }


    //properties

    public double R { get => _r; set => _r = value; }


    //methonds public

    public override double GetArea()
    {
        return Math.PI * R * R;
    }

    public override double GetPerimeter()
    {
        return 2 * Math.PI * R;
    }


    //methonds private

    private double validateR(double r)
    {
        if (r <= 0) 
        {
            throw new ArgumentException("the radius must be greater than zero.");
        }
        return r;
    }

}