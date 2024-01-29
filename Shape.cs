// ---- C# II (Dor Ben Dor) ----
// Wael Abd Elal
// -----------------------------
public abstract class Shape
{
    protected float PositionX;
    protected float PositionY;
    public virtual float Width { get; set; }
    public virtual float Height { get; set; }

    public abstract float Area();
    public abstract float Perimeter();
    public virtual void Draw()
    {
        Console.WriteLine($"Drawing shape at ({PositionX}, {PositionY}) with width {Width} and height {Height}");
    }
}