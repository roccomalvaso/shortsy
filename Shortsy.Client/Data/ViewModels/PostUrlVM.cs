using System.ComponentModel.DataAnnotations;

namespace Shortly_Client.Data.ViewModels;

public class PostUrlVM
{
    [Required(ErrorMessage = "Required Url")]
    [Url(ErrorMessage = "Not a valid URL")]
    public string Url { get; set; }
}