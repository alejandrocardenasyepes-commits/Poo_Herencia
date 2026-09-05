namespace GeometricFigures.Backend;

public class Rhombus : Square
{

    //fields 

   public double _d1;

   public double _d2;

    //constructor

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        
        D1 = d1;
        D2 = d2;

    }

    //properties

    public double D1 { get; private set; }
    public double D2 { get; private set; }

    //methonds public


    public override double GetPerimeter()
    {
        return A * 4;
    }

    public override double GetArea()
    {
        return (D1 * D2) / 2;
    }


    //methonds private 

    private void validateD1(double d1)
    {
        if (d1 <= 0) 
        {
            throw new ArgumentException("the diagonal 1 must be greater than zero.");
        }
    }

    private void validateD2(double d2)
    {
        if (d2 <= 0)
            {
            throw new ArgumentException("the diagonal 2 must be greater than zero.");
            }
    }
}
