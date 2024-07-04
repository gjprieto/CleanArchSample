using CleanArchSample.Common.Kernel.Application.Messages;
using CleanArchSample.Common.Kernel.Application.Results;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Handlers
{
    public interface ICommandHandler<TCommand> : IMessageHandler<TCommand> where TCommand : ICommand
    {
        Task<IMessageResult> HandleAsync(TCommand command);
    }

    public interface ICommandHandler<TCommand, TResult> where TCommand : ICommand
    {
        Task<IMessageResult<TResult>> HandleAsync(TCommand command);
    }

    public interface ICommandHandler<TCommand, TResult, TValidator> where TCommand : ICommand where TValidator : IValidator<TCommand>
    {
        Task<IMessageResult<TResult>> HandleAsync(TCommand command);
    }
}