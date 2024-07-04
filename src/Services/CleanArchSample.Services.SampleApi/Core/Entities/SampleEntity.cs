using CleanArchSample.Common.Kernel.Core.Entities;

namespace CleanArchSample.Services.SampleApi.Core.Entities
{
    public class SampleEntity : EntityBase<Guid>
    {
        public string Prop1 { get; set; }
        public int Prop2 { get; set; }
        public DateTime Prop3 { get; set; }
    }
}