namespace GeometricFigures.Backend;

public abstract class GeometricFigure
{

    //properties

    public string Name { 

        get; 
        set; 

    }

//methonds public
public GeometricFigure(string name)
{
name = name;
}
public abstract double GetArea();
public abstract double Getperimeter();

    public override string ToString()
    {
        return $"{Name,-15} => area...: {GetArea(),12:N5}  perimeter: {Getperimeter(),12:N5}";
    }


}
