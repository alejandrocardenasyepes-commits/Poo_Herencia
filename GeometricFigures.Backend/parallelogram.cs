namespace GeometricFigures.Backend; 

public class parallelogram : rectangle
{

    //fields 

    public double _h;

    // constructor

    public parallelogram(string name, double a, double b, double h) : base(name, a, b)
    {
        validateH(h);
        H = h;
    }

    //properties

    public double H { get; set; }


    //methonds public 

    public override double GetPerimeter()
    {
        return 2 * (A + B);
    }

    public override double GetArea()
    {
        return B * H;
    }

    //methonds private 

    private void validateH(double h)
    {

        if (h <= 0)

        {
            throw new ArgumentException("the h field must be greater than zero.", nameof(h)); 

        }


    }
}
