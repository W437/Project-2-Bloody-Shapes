// ---- C# II (Dor Ben Dor) ----
// Wael Abd Elal
// -----------------------------
public class Circle : Shape
{
    public float Radius { get; set; }

    public Circle(float x, float y, float radius)
    {
        PositionX = x;
        PositionY = y;
        Radius = radius;
        Width = Height = radius * 2;
    }

    public override float Area() => (float)(Math.PI * Radius * Radius);

    public override float Perimeter() => (float)(2 * Math.PI * Radius);

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"Drawing a circle with radius {Radius}");
    }

    public override string ToString() => $"Circle at ({PositionX}, {PositionY}), radius {Radius}";

    public override bool Equals(object obj)
    {
        if (obj is Circle c)
        {
            return PositionX == c.PositionX && PositionY == c.PositionY && Radius == c.Radius;
        }
        return false;
    }

    public override int GetHashCode() => (PositionX, PositionY, Radius).GetHashCode();

    public bool Intersect(Circle other)
    {
        float dx = this.PositionX - other.PositionX;
        float dy = this.PositionY - other.PositionY;
        float distance = (float)Math.Sqrt(dx * dx + dy * dy);

        return distance <= (this.Radius + other.Radius);
    }

}