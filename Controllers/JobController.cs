using Domain.Entities;
using Infrastructure.Interfaces;
using Infrastructure.Responses;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers;


[ApiController]
[Route("[controller]")]

public class JobController(IGenericService<Job> jobService):ControllerBase
{
    [HttpGet]
    public async Task<ApiResponse<List<Job>>> GetAll()
    {
        return await jobService.GetAll();
    }

    [HttpGet("{id:int}")]
    public async Task<ApiResponse<Job>> GetById(int id)
    {
        return await jobService.GetById(id);
    }

    [HttpPost]
    public async Task<ApiResponse<bool>> Add([FromBody] Job job)
    {
        return await jobService.Add(job);
    }

    [HttpPut]
    public async Task<ApiResponse<bool>> Update([FromBody] Job job)
    {
        return await jobService.Update(job);
    }

    [HttpDelete("{id:int}")]
    public async Task<ApiResponse<bool>> Delete(int id)
    {
        return await jobService.Delete(id);
    }
    
}