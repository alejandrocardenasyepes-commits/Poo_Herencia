namespace GeometricFigures.Backend;

public class Triangle : rectangle
{

    //fields 
    public double _c;
 
    public double _h;

    //constructor

    public Triangle(string name, double a, double b, double c, double h) : base(name, a, b)
    { 
        validateH(h);
        validateC(c);
        
        C = c;
        H = h;
    }


    //properties 

    public double C { get; set; }

    public double H { get; set; }


    //methonds public 

    public override double GetPerimeter()
    {
        return A + B + C;
    }

    public override double GetArea()
    {
        return (B * H) / 2;
    }

    // methonds private

    private void validateH(double h) 
    {

        if (h < 0) 
        {
        
            throw new ArgumentException("the h field must be greater than zero. ", nameof(h));
        }
    }

    private void validateC(double c)
    {
        if (c <= 0)
            { 
        throw new ArgumentException("the c field must be greater than zero.", nameof (c));
        }
               
        
    }


}
