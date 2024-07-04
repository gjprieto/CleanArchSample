using CleanArchSample.Common.Kernel.Application.Handlers;
using CleanArchSample.Common.Kernel.Application.Results;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers
{
    public class UpdateSampleEntityCommandHandler : CommandHandlerBase<UpdateSampleEntityCommand, UpdateSampleEntityCommandResult, UpdateSampleEntityCommand.UpdateSampleEntityCommandValidator>
    {
        public UpdateSampleEntityCommandHandler(ILogger logger, UpdateSampleEntityCommand.UpdateSampleEntityCommandValidator validator) : base(logger, validator)
        {
        }

        protected override async Task<IMessageResult<UpdateSampleEntityCommandResult>> DoHandleAsync(UpdateSampleEntityCommand command)
        {
            await Task.CompletedTask;
            return Success();
        }
    }
}