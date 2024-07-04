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
    public abstract class QueryHandlerBase<TQuery, TResult> : MessageHandlerBase<TQuery, TResult>, IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        private readonly ILogger _logger;

        protected override string MessageType => "query";
        protected override string MessageIdKey => "QueryId";

        protected QueryHandlerBase(ILogger logger)
        {
            _logger = logger;
        }

        protected abstract Task<IMessageResult<TResult>> DoHandleAsync(TQuery query);

        public async Task<IMessageResult<TResult>> HandleAsync(TQuery query)
        {
            using (_logger.BeginScope(GetScope(query)))
            {
                try
                {
                    return await DoHandleAsync(query);
                }
                catch (Exception ex)
                {
                    _logger.LogCritical(ex, ex.Message);
                    return Error(ex);
                }
            }
        }
    }

    public abstract class QueryHandlerBase<TQuery, TResult, TValidator> : MessageHandlerBase<TQuery, TResult, TValidator>, IQueryHandler<TQuery, TResult> where TQuery : IQuery where TValidator : IValidator<TQuery>
    {
        private readonly ILogger _logger;

        protected override string MessageType => "query";
        protected override string MessageIdKey => "QueryId";

        protected QueryHandlerBase(ILogger logger, TValidator validator) : base(validator)
        {
            _logger = logger;
        }

        protected abstract Task<IMessageResult<TResult>> DoHandleAsync(TQuery query);

        public async Task<IMessageResult<TResult>> HandleAsync(TQuery query)
        {
            using (_logger.BeginScope(GetScope(query)))
            {
                try
                {
                    if (!TryValidateMessage(query, out var validation)) return NotValid(validation);
                    return await DoHandleAsync(query);
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