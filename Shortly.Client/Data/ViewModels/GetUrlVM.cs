namespace Shortly_Client.Data.ViewModels;

public class GetUrlVM
{
    public int Id { get; set; }
    public string OriginalLink { get; set; }
    public string ShortLink { get; set; }
    public int NrOfClick { get; set; }
    public int? UserId { get; set; }
}