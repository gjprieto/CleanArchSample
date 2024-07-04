using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Messages
{
    public abstract class MessageBase : IMessage
    {
        public string Id { get; }
        public DateTime CreatedOn { get; }
        public string? CreatedBy { get; set; }

        protected MessageBase()
        {
            Id = Guid.NewGuid().ToString();
            CreatedOn = DateTime.UtcNow;
        }
    }
}