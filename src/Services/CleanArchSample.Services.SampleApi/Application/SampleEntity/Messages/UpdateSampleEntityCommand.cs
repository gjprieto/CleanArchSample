using CleanArchSample.Common.Kernel.Application.Messages;
using FluentValidation;

namespace CleanArchSample.Services.SampleApi.Application.SampleEntity.Messages
{
    public class UpdateSampleEntityCommand : CommandBase
    {
        public class UpdateSampleEntityCommandValidator : AbstractValidator<UpdateSampleEntityCommand>
        {
            public UpdateSampleEntityCommandValidator()
            {
                RuleFor(x => x.Id).NotEmpty();
                RuleFor(x => x.Prop1).NotEmpty().MaximumLength(100);
                RuleFor(x => x.Prop2).InclusiveBetween(10, 20);
                RuleFor(x => x.Prop3).LessThan(DateTime.UtcNow.AddDays(1));
            }
        }

        public Guid Id { get; set; }
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
        public DateTime Prop3 { get; set; }
    }
}