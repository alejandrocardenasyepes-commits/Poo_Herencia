namespace GeometricFigures.Backend;

public class Rhombus : Square
{

    //fields 

   public double _d1;

   public double _d2;

    //constructor

    public Rhombus(string name, double a, double d1, double d2) : base(name, a)
    {
        _d1 = D1;
        _d2 = D2;

    }

    //properties

    public double D1 { get; private set; }
    public double D2 { get; private set; }

    //methonds public




    //methonds private 
}
