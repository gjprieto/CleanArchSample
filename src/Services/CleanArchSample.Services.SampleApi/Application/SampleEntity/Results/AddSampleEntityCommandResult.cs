using CleanArchSample.Common.Kernel.Application.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Results
{
    public class AddSampleEntityCommandResult : CommandResult<Guid>
    {
        public AddSampleEntityCommandResult(Guid result) : base(result)
        {
        }
    }
}