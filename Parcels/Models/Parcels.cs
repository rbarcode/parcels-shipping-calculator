
namespace Parcels.Models
{
  public class Parcel
  {

    public int Length { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public int Volume()
    {
      int volume = Length * Width * Height;
      return volume;
    }

    public int CostToShip(int volume)
    {
      int cost = volume * Weight * 100;
      return cost;
    }
  }
}