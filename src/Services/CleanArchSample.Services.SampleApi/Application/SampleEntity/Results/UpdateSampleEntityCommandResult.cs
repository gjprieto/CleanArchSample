using CleanArchSample.Common.Kernel.Application.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Results
{
    public class UpdateSampleEntityCommandResult : CommandResult
    {
        public UpdateSampleEntityCommandResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
        }
    }
}