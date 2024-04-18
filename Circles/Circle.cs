using System;

public class Circles
{
	public Circles()
	{
		
    public double Radius { get; set; }

    
    public Circles(double radius)
    {
        Radius = radius;
    }

   
    public double CalculateCircumference()
    {
        return 2 * Math.PI * Radius;
    }

    
    public double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }

    }
}
