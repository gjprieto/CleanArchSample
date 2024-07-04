using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public class MessageResult : IMessageResult
    {
        public bool IsSuccess { get; }
        public bool IsError => !IsSuccess;
        public bool IsCompleted { get; }
        public bool IsValid => IsCompleted && IsError;
        public bool IsNotValid => !IsValid;
        public string[] ErrorMessages { get; }

        public MessageResult(bool isCompleted, bool isSuccess, string[] errorMessages)
        {
            IsSuccess = isSuccess;
            IsCompleted = isCompleted;
            ErrorMessages = errorMessages;
        }

        public MessageResult(bool isCompleted, bool isSuccess) : this(isSuccess, isSuccess, new string[] { })
        {
            IsSuccess = isSuccess;
            IsCompleted = isCompleted;
        }
    }

    public class MessageResult<TResult> : MessageResult, IMessageResult<TResult>
    {
        public TResult? Result { get; }

        public MessageResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
            Result = default;
        }

        public MessageResult(bool isCompleted, bool isSuccess, string[] errorMessages) : base(isCompleted, isSuccess, errorMessages)
        {
            Result = default;
        }

        public MessageResult(TResult result) : base(true, true)
        {
            Result = result;
        }
    }
}