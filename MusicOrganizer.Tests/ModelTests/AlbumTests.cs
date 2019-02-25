using System;
using MusicOrganizer.Models;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTest
  {
    [TestMethod]
    // public void MethodName_MethodDescription_Result()
    public void CheckString_IsThisAString_Bool()
    {
      // var name = ...;
      // string book = "This has words. And quoted numbers, 43."
      // int numbers = 43;
      // bool coin = true; (heads)
      // bool coin = false; (tails)
      // string[] array = {"many", "things"};
      // int[] array = {1, 2, 3};
      string words = "This is a string";
      // bool result = (words is string);
      bool result = true;
      if (words is string)
      {
        result = true;
      }
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void AlbumConstructor_CreateAnInstanceOfAnAlbum_Album()
    {
      Album newAlbum = new Album("test album");
      Assert.AreEqual(nameof(Album), new Album().GetName());

    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "Test Album";
      Album newAlbum = new Album(name);
      int result = newAlbum.GetId();
      Assert.AreEqual(1, result);
    }

    // Album eggWash = new Album();
    // bool result = eggWash.DoThisThing();
    //
    // bool result = DoThisThing();

  }
}
