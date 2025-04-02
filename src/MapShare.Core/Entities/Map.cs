using MapShare.Core.Common;
using MapShare.Core.Enums;

namespace MapShare.Core.Entities;

public class Map : BaseEntity
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public int Views { get; private set; }
    public int Likes { get; private set; }
    public Privacy Privacy { get; private set; }
    public DateTime CreationDate { get; private set; }
    public DateTime UpdateDate { get; private set; }
    
    public Map(string title, string description, int views, int likes, Privacy privacy, 
        DateTime creationDate, DateTime updateDate)
    {
        Title = title;
        Description = description;
        Views = views;
        Likes = likes;
        Privacy = privacy;
        CreationDate = creationDate;
        UpdateDate = updateDate;
    }
}