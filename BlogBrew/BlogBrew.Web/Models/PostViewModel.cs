using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogBrew.Web.Models;

public class PostViewModel
{
    public SelectList Categories { get; set; } = new SelectList(Enumerable.Empty<SelectListItem>());

    public IFormFile Image { get; set; }
}