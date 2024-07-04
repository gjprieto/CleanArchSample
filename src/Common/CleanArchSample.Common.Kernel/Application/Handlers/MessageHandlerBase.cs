using CleanArchSample.Common.Kernel.Application.Messages;
using CleanArchSample.Common.Kernel.Application.Results;
using FluentValidation;
using FluentValidation.Results;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Handlers
{
    public abstract class MessageHandlerBase<TMessage> : IMessageHandler<TMessage> where TMessage : IMessage
    {
        protected virtual string MessageType => "message";
        protected virtual string MessageIdKey => "MessageId";

        protected virtual Dictionary<string, string> GetScope(TMessage message)
        {
            return new Dictionary<string, string> {
                { "MessageType", MessageType },
                { MessageIdKey, message.Id },
                { "HandlerType", GetType().Name },
                { "HandledOn", DateTime.UtcNow.ToString("yyyy/MM/dd hh:mm:ss:fff") }
            };
        }

        protected virtual IMessageResult Success() => new MessageResult(true, true);
        protected virtual IMessageResult Error(Exception ex) => new MessageResult(true, false, new string[] { ex.Message });
        protected virtual IMessageResult Error(string[] errors) => new MessageResult(true, false, errors);
    }

    public abstract class MessageHandlerBase<TMessage, TResult> : MessageHandlerBase<TMessage>, IMessageHandler<TMessage, TResult> where TMessage : IMessage
    {
        protected new virtual IMessageResult<TResult> Success() => new MessageResult<TResult>(true, true);
        protected virtual IMessageResult<TResult> Success(TResult result) => new MessageResult<TResult>(result);
        protected override IMessageResult<TResult> Error(Exception ex) => new MessageResult<TResult>(true, false, new string[] { ex.Message });
        protected override IMessageResult<TResult> Error(string[] errors) => new MessageResult<TResult>(true, false, errors);
    }

    public abstract class MessageHandlerBase<TMessage, TResult, TValidator> : MessageHandlerBase<TMessage, TResult>, IMessageHandler<TMessage, TResult> where TMessage : IMessage where TValidator : IValidator<TMessage>
    {
        private readonly TValidator _messageValidator;

        protected MessageHandlerBase(TValidator messageValidator)
        {
            _messageValidator = messageValidator;
        }

        protected virtual IMessageResult<TResult>? NotValid(ValidationResult validationResult) => new MessageResult<TResult>(true, false, validationResult.Errors.Select(x => x.ErrorMessage).ToArray());

        protected virtual bool TryValidateMessage(TMessage message, out ValidationResult validation)
        {
            if (message == null) throw new ArgumentNullException("message");
            validation = _messageValidator.Validate(message);
            return validation.IsValid;
        }
    }
}
