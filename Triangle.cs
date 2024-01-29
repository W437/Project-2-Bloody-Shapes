// ---- C# II (Dor Ben Dor) ----
// Wael Abd Elal
// -----------------------------
public class Triangle : Shape
{
    public float X1 { get; private set; }
    public float Y1 { get; private set; }
    public float X2 { get; private set; }
    public float Y2 { get; private set; }
    public float X3 { get; private set; }
    public float Y3 { get; private set; }

    public Triangle(float x1, float y1, float x2, float y2, float x3, float y3)
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
        X3 = x3;
        Y3 = y3;

        UpdateBoundingRectangle();
    }

    private void UpdateBoundingRectangle()
    {
        float minX = Math.Min(X1, Math.Min(X2, X3));
        float minY = Math.Min(Y1, Math.Min(Y2, Y3));
        float maxX = Math.Max(X1, Math.Max(X2, X3));
        float maxY = Math.Max(Y1, Math.Max(Y2, Y3));

        PositionX = minX;
        PositionY = minY;
        Width = maxX - minX;
        Height = maxY - minY;
    }

    public override float Area()
    {
        float area = Math.Abs(X1 * (Y2 - Y3) + X2 * (Y3 - Y1) + X3 * (Y1 - Y2)) / 2.0f;
        return area;
    }


    public override float Perimeter()
    {
        return Distance(X1, Y1, X2, Y2) + Distance(X2, Y2, X3, Y3) + Distance(X3, Y3, X1, Y1);
    }

    private float Distance(float x1, float y1, float x2, float y2)
    {
        return (float)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public override void Draw()
    {
        Console.WriteLine($"Drawing a triangle with vertices ({X1}, {Y1}), ({X2}, {Y2}), ({X3}, {Y3})");
    }

    public override string ToString()
    {
        return $"Triangle with vertices ({X1}, {Y1}), ({X2}, {Y2}), ({X3}, {Y3})";
    }

    public override bool Equals(object obj)
    {
        if (obj is Triangle other)
        {
            return X1 == other.X1 && Y1 == other.Y1 &&
                   X2 == other.X2 && Y2 == other.Y2 &&
                   X3 == other.X3 && Y3 == other.Y3;
        }
        return false;
    }

    public override int GetHashCode() => (X1, Y1, X2, Y2, X3, Y3).GetHashCode();
}
