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
Name = name;
}
public abstract double GetArea();
public abstract double GetPerimeter();

    public override string ToString()
    {
        return $"{Name,-15} => Area.....: {GetArea():N5}  perimeter: {GetPerimeter():N5}";
    }


}
