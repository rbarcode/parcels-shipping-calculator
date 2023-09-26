using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcels.Models;
using System;

namespace Parcels.Tests
{
  [TestClass]
  public class ParcelTests
  {
    
    [TestMethod]
    public void ParcelConstructor_CreatesInstanceOfParcel_Parcel()
    {
      Parcel newParcel = new Parcel(3, 3, 3, 2);
      Assert.AreEqual(typeof(Parcel), newParcel.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Int()
    {
      int length = 4;
      Parcel newParcel = new(length, 3, 3, 2);
      int result = newParcel.Length;
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void SetLength_SetsValueOfLength_Void()
    {
      Parcel newParcel = new(5, 3, 3, 2);
      int length = 4;
      newParcel.Length = length;
      Assert.AreEqual(length, newParcel.Length);
    }

    [TestMethod]
    public void GetWidth_ReturnWidth_Int()
    {
      int width = 2;
      Parcel newParcel = new(2, width, 3, 2);
      int result = newParcel.Width;
      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void SetWidth_SetsValueOfWidth_Void()
    {
     Parcel newParcel = new(5, 3, 3, 2);
     int width = 4;
     newParcel.Width = width;
     Assert.AreEqual(width, newParcel.Width);
    }
  
    [TestMethod]
    public void GetHeight_GetsHeight_Int()
    {
      int height = 6;
      Parcel newParcel = new(3, 3, height, 2);
      int result = newParcel.Height;
      Assert.AreEqual(height, result);
    }

    [TestMethod]
    public void SetHeight_SetsHeight_Void()
    {
      Parcel newParcel = new(4, 4, 6, 2);
      int newHeight = 2;
      newParcel.Height = newHeight;
      Assert.AreEqual(newHeight, newParcel.Height);
    }

    [TestMethod]
    public void GetWeight_GetsWeight_Int()
    {
      int weight = 10;
      Parcel newParcel = new (3, 3, 3, weight);
      int result = newParcel.Weight;
      Assert.AreEqual(weight, result);
    }

    [TestMethod]
    public void SetWeight_SetsWeight_Void()
    {
      Parcel newParcel = new(3, 3, 3, 10);
      int newWeight = 5;
      newParcel.Weight = newWeight;
      Assert.AreEqual(newWeight, newParcel.Weight);
    }

    [TestMethod]
    public void Volume_CalculateVolumeForParcel_Int()
    {
      Parcel newParcel = new(2, 2, 5, 10);
      int newVolume = newParcel.Volume();
      Assert.AreEqual(20, newVolume);
    }

    [TestMethod]
    public void CostToShip_CalcCostToShip_Int()
    {
      Parcel newParcel = new(2, 2, 5, 10);
      int newVolume = newParcel.Volume();
      int price = newParcel.CostToShip(newVolume);
      Assert.AreEqual(20000, price);
    }
  }
}