using CleanArchSample.Common.Kernel.Application.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Results
{
    public class DeleteSampleEntityCommandResult : CommandResult
    {
        public DeleteSampleEntityCommandResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
        }
    }
}