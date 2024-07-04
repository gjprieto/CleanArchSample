using CleanArchSample.Common.Kernel.Application.Messages;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages
{
    public class FindSampleEntityByIdQuery : QueryBase
    {
        public Guid Id { get; set; }
    }
}