using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public interface IMessageResult
    {
        bool IsSuccess { get; }
        bool IsError { get; }
        bool IsCompleted { get; }
        bool IsValid { get; }
        bool IsNotValid { get; }

        string[] ErrorMessages { get; }
    }

    public interface IMessageResult<TResult> : IMessageResult
    {
        TResult? Result { get; }
    }
}