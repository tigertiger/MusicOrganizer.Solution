namespace MusicOrganizer.Models
{
  public class Album
  {
  
    public string Title { get; set; }
    public string Artist { get; set; }

    public Album (string title, string artist)
    {
      Title = title;
      Artist = artist;
    }

  }
}