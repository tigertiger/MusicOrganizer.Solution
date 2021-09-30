using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrganizer.Models;
using System;

namespace MusicOrganizer.Tests
{
  [TestClass]
  public class GenreTests : IDisposable
  {

    public void Dispose()
    {
      Genre.ClearAll();
    }

    [TestMethod]
    public void GenreConstructor_CreatesInstanceOfGenre_Genre()
    {
      Genre newGenre = new Genre("Death Metal");
      Assert.AreEqual(typeof(Genre), newGenre.GetType());
    }

    [TestMethod]
    public void GetDescrip_ReturnsDescrip_String()
    {
      string descrip = "Death Metal";
      Genre newGenre = new Genre(descrip);

      string result = newGenre.Descrip;

      Assert.AreEqual(descrip, result);
    }

    [TestMethod]
    public void GetId_ReturnsGenreId_Int()
    {
      string descrip = "Death Metal";
      Genre newGenre = new Genre(descrip);

      int result = newGenre.Id;

      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllGenreObjects_GenreList()
    {
      string descrip01 = "Death Metal";
      string descrip02 = "Pop Country";
      Genre newGenre01 = new Genre(descrip01);
      Genre newGenre02 = new Genre(descrip02);
      List<Genre> newList = new List<Genre> { newGenre01, newGenre02};

      List<Genre> result = Genre.GetAll();

      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectGenre_Genre()
    {
      string descrip01 = "Death Metal";
      string descrip02 = "Pop Country";
      Genre newGenre01 = new Genre(descrip01);
      Genre newGenre02 = new Genre(descrip02);

      Genre result = Genre.Find(2);

      Assert.AreEqual(newGenre02, result);
    }

    [TestMethod]
    public void AddAlbum_AssociatesAlbumWithGenre_AlbumList()
    {
      string title = "Symbolic";
      string artist = "Death";
      Album newAlbum = new Album(title, artist);
      List<Album> newList = new List<Album> { newAlbum };
      string descrip = "Death Metal";
      Genre newGenre = new Genre(descrip);
      newGenre.AddAlbum(newAlbum);

      List<Album> result = newGenre.Albums;

      CollectionAssert.AreEqual(newList, result);
    }
  }
}