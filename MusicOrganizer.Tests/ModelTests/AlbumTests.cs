using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class AlbumTests : IDisposable
  {

    public void Dispose()
    {
      Album.ClearAll();
    }

    [TestMethod]
    public void AlbumConstructor_CreatesInstanceOfAlbum_Album()
    {
      Album newAlbum = new Album("Ride the Lightning", "Metallica");
      Assert.AreEqual(typeof(Album), newAlbum.GetType());
    }

    [TestMethod]
    public void GetTitleAndArtist_ReturnsTitleAndArtist_StringString()
    {
      string title = "Astral Weeks";
      string artist = "Van Morrison";

      Album newAlbum = new Album(title, artist);
      string titleResult = newAlbum.Title;
      string artistResult = newAlbum.Artist;

      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(artist, artistResult);
    }

    [TestMethod]
    public void ChangeTitleAndArtist_ChangeTitleAndArtist_StringString()
    {
      string title = "Astral Weeks";
      string artist = "Van Morrison";
      Album newAlbum = new Album(title, artist);

      string updatedTitle = "Mercenary";
      string updatedArtist = "Bolt Thrower";
      newAlbum.Title = updatedTitle;
      newAlbum.Artist = updatedArtist;
      string titleResult = newAlbum.Title;
      string artistResult = newAlbum.Artist;

      Assert.AreEqual(updatedTitle, titleResult);
      Assert.AreEqual(updatedArtist, artistResult);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_AlbumList()
    {
      List<Album> newList = new List<Album> {};

      List<Album> result = Album.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAlbums_AlbumList()
    {
      string title01 = "Cause of Death";
      string artist01 = "Obituary";
      string title02 = "Consuming Impulse";
      string artist02 = "Pestilence";
      Album newAlbum01 = new Album(title, artist);
      Album newAlbum02 = new Album(title, artist);
      List<Album> newList = new List<Album> { newAlbum01, newAlbum02};

      List<Album> result = Album.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_AlbumsInstantiateWithAnIdAndGetReturns_Int()
    {
      string title = "CLPPNG";
      string artist = "clipping";
      Album newAlbum = new Album(title, artist);

      int result = newAlbum.Id;

      Assert.AreEqual(1, result);
    }
    
  }
}