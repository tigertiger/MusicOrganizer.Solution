using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using MusicOrganizer.Models;

namespace MusicOrganizer.Controllers
{

  public class GenresController : Controller
  {

    [HttpGet("/genres")]
    public ActionResult Index()
    {
      List<Genre> allGenres = Genre.GetAll();
      return View(allGenres);
    }

    [HttpGet("/genres/new")]
    public ActionResult New()
    {
      return View();
    }

// Create Genres
    [HttpPost("/genres")]
    public ActionResult Create(string genreDescrip)
    {
      Genre newGenre = new Genre(genreDescrip);
      return RedirectToAction("Index");
    }

    [HttpGet("/genres/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre selectedGenre = Genre.Find(id);
      List<Album> genreAlbums = selectedGenre.Albums;
      model.Add("genre", selectedGenre);
      model.Add("albums", genreAlbums);
      return View(model);
    }

// Create album within Genre
    [HttpPost("/genres/{genreId}/albums")]
    public ActionResult Show(int genreId, string albumTitle, string albumArtist)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Genre foundGenre = Genre.Find(genreId);
      Album newAlbum = new Album(albumTitle, albumArtist);
      foundGenre.AddAlbum(newAlbum);
      List<Album> genreAlbums = foundGenre.Albums;
      model.Add("albums", genreAlbums);
      model.Add("genre", foundGenre);
      return View("Show", model);
    }


  }

}