using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MusicOrganizer.Models;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class ArtistTest
  {
    [TestMethod]
    // public void MethodName_MethodDescription_Result()
    public void CheckString_IsTheUserInputtingAString_Bool()
    {
      // Arrange (Raw information)
      string testInput = "This is a string?";

      // Act (Do things with information) POST-REFACTOR
      bool result = (testInput is string);

      // Act (Do things with information) PRE-REFACTOR
      // bool result = false;
      // if (testInput is string)
      // {
      //   result = true;
      // }
      // Refactor Note: bool result absorbs if statement for direct check of true/false

      // Assert (Check result of information)
      Assert.AreEqual(true, result);
    }

    [TestMethod]
    public void ArtistConstructor_CreateAnInstanceOfAnArtist_Artist()
    {
      // POST-REFACTOR #2:
      // Arrange
      // Act
      // Assert
      Assert.AreEqual(typeof(Artist), new Artist().GetType());

      // POST-REFACTOR #1:
      // // Arrange
      // Artist newArtist = new Artist();
      // Act
      // Assert
      //Assert.AreEqual(typeof(Artist), newArtist.GetType());

      // PRE-REFACTOR:
      // // Arrange
      // Artist newArtist = new Artist();
      // // Act
      // System.Type result = newArtist.GetType();
      // // Assert
      // Assert.AreEqual(typeof(Artist), result);
      // Is actually checking: typeof(Artist) = result = newArtist.GetType()
    }
  }
}
