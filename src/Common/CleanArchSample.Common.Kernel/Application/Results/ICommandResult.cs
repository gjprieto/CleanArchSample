using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public interface ICommandResult : IMessageResult
    {
    }

    public interface ICommandResult<TResult> : IMessageResult<TResult>
    {
    }
}