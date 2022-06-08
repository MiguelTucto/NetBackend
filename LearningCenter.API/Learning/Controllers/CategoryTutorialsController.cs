using AutoMapper;
using LearningCenter.API.Learning.Domain.Models;
using LearningCenter.API.Learning.Domain.Services;
using LearningCenter.API.Learning.Resources;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Learning.Controllers;

[ApiController]
[Route("/api/v1/categories/{categoryId}/tutorials")] // Nested Resources
public class CategoryTutorialsController : ControllerBase
{
    private readonly ITutorialService _tutorialService;
    private readonly IMapper _mapper;

    public CategoryTutorialsController(IMapper mapper, ITutorialService tutorialService)
    {
        _mapper = mapper;
        _tutorialService = tutorialService;
    }

    [HttpGet]
    public async Task<IEnumerable<TutorialResource>> GetAllByCategoryId(int categoryId)
    {
        var tutorials = await _tutorialService.ListByCategoryIdAsync(categoryId);

        var resources = _mapper.Map<IEnumerable<Tutorial>, IEnumerable<TutorialResource>>(tutorials);

        return resources;
    } 
}