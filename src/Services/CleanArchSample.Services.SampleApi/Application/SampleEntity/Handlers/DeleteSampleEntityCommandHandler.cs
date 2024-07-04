using CleanArchSample.Common.Kernel.Application.Handlers;
using CleanArchSample.Common.Kernel.Application.Results;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers
{
    public class DeleteSampleEntityCommandHandler : CommandHandlerBase<DeleteSampleEntityCommand, DeleteSampleEntityCommandResult, DeleteSampleEntityCommand.DeleteSampleEntityCommandValidator>
    {
        public DeleteSampleEntityCommandHandler(ILogger logger, DeleteSampleEntityCommand.DeleteSampleEntityCommandValidator validator) : base(logger, validator)
        {
        }

        protected override async Task<IMessageResult<DeleteSampleEntityCommandResult>> DoHandleAsync(DeleteSampleEntityCommand command)
        {
            await Task.CompletedTask;
            return Success();
        }
    }
}