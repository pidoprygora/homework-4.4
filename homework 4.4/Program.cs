public abstract class GeographicObject
{
    public double X { get; set; }
    public double Y { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public GeographicObject(double x, double y, string name, string description)
    {
        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public virtual string GetInformation()
    {
        return $"Name: {Name}\n Coordinate (X, Y): ({X}, {Y})\n Description: {Description}";
    }
}

public class River : GeographicObject
{
    public double FlowSpeed { get; set; }
    public double TotalLength { get; set; }

    public River(double x, double y, string name, string description, double flowSpeed, double totalLength)
        : base(x, y, name, description)
    {
        FlowSpeed = flowSpeed;
        TotalLength = totalLength;
    }

    public override string GetInformation()
    {
        string baseInfo = base.GetInformation();
        return $"{baseInfo}\n Flow speed: {FlowSpeed} cm/s\n Total length: {TotalLength} km";
    }
}

public class Mountain : GeographicObject
{
    public double HighestPoint { get; set; }

    public Mountain(double x, double y, string name, string description, double highestPoint)
        : base(x, y, name, description)
    {
        HighestPoint = highestPoint;
    }

    public override string GetInformation()
    {
        string baseInfo = base.GetInformation();
        return $"{baseInfo}\n The highest point: {HighestPoint}";
    }
}
