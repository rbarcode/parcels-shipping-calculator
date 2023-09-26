
namespace Parcels.Models
{
  public class Parcel
  {

    public int Length { get; set; }

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
    }
  }
}