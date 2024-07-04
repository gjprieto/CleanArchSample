using CleanArchSample.Common.Kernel.Application.Messages;
using CleanArchSample.Common.Kernel.Application.Results;
using FluentValidation;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Handlers
{
    public abstract class CommandHandlerBase<TCommand> : MessageHandlerBase<TCommand>, ICommandHandler<TCommand> where TCommand : ICommand
    {
        private readonly ILogger _logger;

        protected override string MessageType => "command";
        protected override string MessageIdKey => "CommandId";

        protected CommandHandlerBase(ILogger logger)
        {
            _logger = logger;
        }

        protected abstract Task<IMessageResult> DoHandleAsync(TCommand command);

        public async Task<IMessageResult> HandleAsync(TCommand command)
        {
            using (_logger.BeginScope(GetScope(command)))
            {
                try
                {
                    return await DoHandleAsync(command);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex, ex.Message);
                    return Error(ex);
                }
            }
        }
    }

    public abstract class CommandHandlerBase<TCommand, TResult> : MessageHandlerBase<TCommand, TResult>, ICommandHandler<TCommand, TResult> where TCommand : ICommand
    {
        private readonly ILogger _logger;

        protected override string MessageType => "command";
        protected override string MessageIdKey => "CommandId";

        protected CommandHandlerBase(ILogger logger)
        {
            _logger = logger;
        }

        protected abstract Task<IMessageResult<TResult>> DoHandleAsync(TCommand command);

        public async Task<IMessageResult<TResult>> HandleAsync(TCommand command)
        {
            using (_logger.BeginScope(GetScope(command)))
            {
                try
                {
                    return await DoHandleAsync(command);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex, ex.Message);
                    return Error(ex);
                }
            }
        }
    }

    public abstract class CommandHandlerBase<TCommand, TResult, TValidator> : MessageHandlerBase<TCommand, TResult, TValidator>, ICommandHandler<TCommand, TResult> where TCommand : ICommand where TValidator : IValidator<TCommand>
    {
        private readonly ILogger _logger;

        protected override string MessageType => "command";
        protected override string MessageIdKey => "CommandId";

        protected CommandHandlerBase(ILogger logger, TValidator validator) : base(validator)
        {
            _logger = logger;
        }

        protected abstract Task<IMessageResult<TResult>> DoHandleAsync(TCommand command);

        public async Task<IMessageResult<TResult>> HandleAsync(TCommand command)
        {
            using (_logger.BeginScope(GetScope(command)))
            {
                try
                {
                    if (!TryValidateMessage(command, out var validation)) return NotValid(validation);
                    return await DoHandleAsync(command);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex, ex.Message);
                    return Error(ex);
                }
            }
        }
    }
}