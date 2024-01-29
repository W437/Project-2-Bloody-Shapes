// ---- C# II (Dor Ben Dor) ----
// Wael Abd Elal
// -----------------------------
public class Rectangle : Shape
{
    public Rectangle(float x, float y, float width, float height)
    {
        PositionX = x;
        PositionY = y;
        Width = width;
        Height = height;
    }

    public override float Area() => Width * Height;

    public override float Perimeter() => 2 * (Width + Height);

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"Drawing a rectangle with width {Width} and height {Height}");
    }

    public override string ToString() => $"Rectangle at ({PositionX}, {PositionY}), width {Width}, height {Height}";

    public override bool Equals(object obj)
    {
        if (obj is Rectangle r)
        {
            return PositionX == r.PositionX && PositionY == r.PositionY && Width == r.Width && Height == r.Height;
        }
        return false;
    }

}
