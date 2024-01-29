// ---- C# II (Dor Ben Dor) ----
// Wael Abd Elal
// -----------------------------
public sealed class Square : Rectangle
{
    public Square(float x, float y, float size) : base(x, y, size, size) { }


    // solution to the problem?
    public override float Width
    {
        get => base.Width;
        set
        {
            base.Width = value;
            base.Height = value;
        }
    }

    public override float Height
    {
        get => base.Height;
        set => Width = value; // width = height
    }
    public override void Draw()
    {
        base.Draw();
        Console.WriteLine("Drawing a square.");
    }

    public override string ToString() => $"Square at ({PositionX}, {PositionY}), size {Width}";
}
