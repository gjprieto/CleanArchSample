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
    public interface IQueryHandler<TQuery, TResult> where TQuery : IQuery
    {
        Task<IMessageResult<TResult>> HandleAsync(TQuery query);
    }

    public interface IQueryHandler<TQuery, TResult, TValidator> where TQuery : IQuery where TValidator : IValidator<TQuery>
    {
        Task<IMessageResult<TResult>> HandleAsync(TQuery query);
    }
}