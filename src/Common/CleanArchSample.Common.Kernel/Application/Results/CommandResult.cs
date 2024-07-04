using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public class CommandResult : MessageResult, ICommandResult
    {
        public CommandResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
        }

        public CommandResult(bool isCompleted, bool isSuccess, string[] errorMessages) : base(isCompleted, isSuccess, errorMessages)
        {
        }
    }

    public class CommandResult<TResult> : MessageResult<TResult>, ICommandResult<TResult>
    {
        public CommandResult(TResult result) : base(result)
        {
        }

        public CommandResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
        }

        public CommandResult(bool isCompleted, bool isSuccess, string[] errorMessages) : base(isCompleted, isSuccess, errorMessages)
        {
        }
    }
}