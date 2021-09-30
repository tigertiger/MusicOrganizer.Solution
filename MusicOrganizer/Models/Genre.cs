using System.Collections.Generic;
namespace MusicOrganizer.Models
{
  public class Genre
  {

    public string Descrip { get; set; }
    public int Id { get; }
    private static List<Genre> _buckets = new List<Genre> {};
    public List<Album> Albums { get; set; }

    public Genre (string descrip)
    {
      Descrip = descrip;
      _buckets.Add(this);
      Id = _buckets.Count;
      Albums = new List<Album>{};
    }

    public static void ClearAll()
    {
      _buckets.Clear();
    }

    public static List<Genre> GetAll()
    {
      return _buckets;
    }

    public static Genre Find(int searchId)
    {
      return _buckets[searchId-1];
    }

    public void AddAlbum(Album album)
    {
      Albums.Add(album);
    }
  }
}