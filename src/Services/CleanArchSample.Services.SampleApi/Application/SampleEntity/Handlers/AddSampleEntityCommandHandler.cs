using CleanArchSample.Common.Kernel.Application.Handlers;
using CleanArchSample.Common.Kernel.Application.Results;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Results;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers
{
    public class AddSampleEntityCommandHandler : CommandHandlerBase<AddSampleEntityCommand, AddSampleEntityCommandResult, AddSampleEntityCommand.AddSampleEntityCommandValidator>
    {
        public AddSampleEntityCommandHandler(ILogger logger, AddSampleEntityCommand.AddSampleEntityCommandValidator validator) : base(logger, validator)
        {
        }

        protected override async Task<IMessageResult<AddSampleEntityCommandResult>> DoHandleAsync(AddSampleEntityCommand command)
        {
            await Task.CompletedTask;
            return Success(new AddSampleEntityCommandResult(Guid.NewGuid()));
        }
    }
}