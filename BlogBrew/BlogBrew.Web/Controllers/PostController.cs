using BlogBrew.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlogBrew.Web.Controllers;

public class PostController : Controller
{
    private readonly IPostService _postService;

    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    public IActionResult Create()
    {
        return View();
    }
}
