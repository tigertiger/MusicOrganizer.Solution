using System.Collections.Generic;
namespace MusicOrganizer.Models
{
  public class Album
  {
  
    public string Title { get; set; }
    public string Artist { get; set; }
    public int Id {get ; }
    private static List<Album> _collection = new List<Album> {};

    public Album (string title, string artist)
    {
      Title = title;
      Artist = artist;
      _collection.Add(this);
      Id = _collection.Count;
    }

    public static List<Album> GetAll()
    {
      return _collection;
    }

    public static void ClearAll()
    {
      _collection.Clear();
    }

  }
}