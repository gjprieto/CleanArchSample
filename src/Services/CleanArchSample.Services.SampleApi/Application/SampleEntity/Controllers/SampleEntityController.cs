using CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SampleEntityController : ControllerBase
    {
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id, [FromServices] FindSampleEntityByIdQueryHandler handler)
        {
            var query = new FindSampleEntityByIdQuery { Id = id };
            var result = await handler.HandleAsync(query);

            if (result.IsNotValid) return BadRequest(result.ErrorMessages);
            if (result.IsError) return StatusCode(500);

            return Ok(result.Result.Result);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddSampleEntityCommand command, [FromServices] AddSampleEntityCommandHandler handler)
        {
            var result = await handler.HandleAsync(command);

            if (result.IsNotValid) return BadRequest(result.ErrorMessages);
            if (result.IsError) return StatusCode(500);

            return Ok();
        }

        [HttpPut()]
        public async Task<IActionResult> Put([FromBody] UpdateSampleEntityCommand command, [FromServices] UpdateSampleEntityCommandHandler handler)
        {
            var result = await handler.HandleAsync(command);

            if (result.IsNotValid) return BadRequest(result.ErrorMessages);
            if (result.IsError) return StatusCode(500);

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id, [FromServices] DeleteSampleEntityCommandHandler handler)
        {
            var result = await handler.HandleAsync(new DeleteSampleEntityCommand { Id = id });

            if (result.IsNotValid) return BadRequest(result.ErrorMessages);
            if (result.IsError) return StatusCode(500);

            return Ok();
        }
    }
}