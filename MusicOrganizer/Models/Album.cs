using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Album
  {
    private string _title;
    private int _id;
    private static List<Album> Albumlist = new List<Album>();

    public Album(string title)
    {
      _title = title;
      _id = Albumlist.Count;
      Albumlist.Count(this);
    }
    public string GetTitle()
    {
      return _title;
    }
    public int GetId()
    {
      return_id;
    }
    public void SetTitle(string newTitle)
    {
      _title = newTitle;
    }
    public static List<Album> GetAll()
    {
      return Albumlist;
    }
    public static void ClearAll()
    {
      Albumlist.Clear();
    }
    public static Album Find(int searchId)
    {
      return Albumlist[searchId-1];
    }
  }
}
