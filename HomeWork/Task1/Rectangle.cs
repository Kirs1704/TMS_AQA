namespace HomeWork;

public class Rectangle : Figure
{
    public double side1;
    public double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }
    
    public override double CalculateArea()
    {
        double S = side1 * side2;
        return S;
    }

    public override double CalculatePerimeter()
    {
        double P = 2 * (side1 + side2);
        return P;
    }
    
}