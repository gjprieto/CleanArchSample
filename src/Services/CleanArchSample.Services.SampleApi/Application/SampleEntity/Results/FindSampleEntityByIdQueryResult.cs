using CleanArchSample.Common.Kernel.Application.Messages;
using CleanArchSample.Common.Kernel.Application.Results;
using CleanArchSample.Services.SampleApi.Application.SampleEntity.Dtos;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages
{
    public class FindSampleEntityByIdQueryResult : QueryResult<SampleEntityDto>
    {
        public FindSampleEntityByIdQueryResult(SampleEntityDto result) : base(result)
        {
        }
    }
}