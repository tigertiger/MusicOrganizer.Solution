using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests
  {
    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("Ride the Lightning", "Metallica");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      string title = "Astral Weeks";
      string artist = "Van Morrison";

      Album newAlbum = new Album(title, artist);
      string titleResult = newAlbum.Title;
      string artistResult = newAlbum.Artist;

      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(artist, artistResult);
    }
    
  }
}