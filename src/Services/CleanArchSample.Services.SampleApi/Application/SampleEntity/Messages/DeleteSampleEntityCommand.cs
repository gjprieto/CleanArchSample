using CleanArchSample.Common.Kernel.Application.Messages;
using FluentValidation;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages
{
    public class DeleteSampleEntityCommand : CommandBase
    {
        public class DeleteSampleEntityCommandValidator : AbstractValidator<DeleteSampleEntityCommand>
        {
            public DeleteSampleEntityCommandValidator()
            {
                RuleFor(x => x.Id).NotEmpty();
            }
        }

        public Guid Id { get; set; }
    }
}