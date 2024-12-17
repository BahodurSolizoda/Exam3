using System.Net.Mime;
using Domain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;

[ApiController]
[Route("[controller]")]

public class ApplicationController(IGenericService<Application> applicationService):ControllerBase
{
    [HttpGet]
    public async Task<ApiResponse<List<Application>>> GetAll()
    {
        return await applicationService.GetAll();
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Application>> GetById(int id)
    {
        return await applicationService.GetById(id);
    }

    [HttpPost]
    public async Task<ApiResponse<bool>> Add([FromBody] Application application)
    {
        return await applicationService.Add(application);
    }

    [HttpPut]
    public async Task<ApiResponse<bool>> Update([FromBody] Application application)
    {
        return await applicationService.Update(application);
    }

    [HttpDelete("{id:int}")]
    public async Task<ApiResponse<bool>> Delete(int id)
    {
        return await applicationService.Delete(id);
    }
    
}