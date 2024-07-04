using CleanArchSample.Common.Kernel.Application.Handlers;
using CleanArchSample.Common.Kernel.Application.Results;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Handlers
{
    public class FindSampleEntityByIdQueryHandler : QueryHandlerBase<FindSampleEntityByIdQuery, FindSampleEntityByIdQueryResult>
    {
        public FindSampleEntityByIdQueryHandler(ILogger logger) : base(logger)
        {
        }

        protected override async Task<IMessageResult<FindSampleEntityByIdQueryResult>> DoHandleAsync(FindSampleEntityByIdQuery query)
        {
            await Task.CompletedTask;
            return Success();
        }
    }
}