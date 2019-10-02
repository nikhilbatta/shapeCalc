namespace Shapes.Models
{
  public class Cube
  {
    public Rectangle Face { get; set; }

    public Cube (Rectangle side)
    {
      Face = side;
    }
    public int GetVolume()
    {
        int length = Face.Length;
        return (length * length) * 6;
    }
    public int GetSurfaceArea()
    {
        return 0;
    }
  }
}