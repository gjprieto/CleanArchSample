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
    public interface IMessageHandler<TMessage> where TMessage : IMessage
    {
    }

    public interface IMessageHandler<TMessage, TResult> where TMessage : IMessage
    {
    }

    public interface IMessageHandler<TMessage, TResult, TValidator> where TMessage : IMessage where TValidator : IValidator<TMessage>
    {
    }
}