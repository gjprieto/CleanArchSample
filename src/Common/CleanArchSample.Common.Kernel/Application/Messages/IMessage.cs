using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Messages
{
    public interface IMessage
    {
        string Id { get; }
        DateTime CreatedOn { get; }
        string? CreatedBy { get; }
    }
}