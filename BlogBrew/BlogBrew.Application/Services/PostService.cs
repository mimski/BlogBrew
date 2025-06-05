using BlogBrew.Application.DTOs;
using BlogBrew.Application.Interfaces;
using BlogBrew.Domain.Interfaces;

namespace BlogBrew.Application.Services;

public class PostService : IPostService
{
    private readonly IPostRepository _postRepo;
    private readonly ICategoryRepository _categoryRepo;

    public PostService(IPostRepository postRepo, ICategoryRepository categoryRepo)
    {
        _postRepo = postRepo;
        _categoryRepo = categoryRepo;
    }
}
