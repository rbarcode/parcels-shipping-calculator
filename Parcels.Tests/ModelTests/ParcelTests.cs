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
  }
}