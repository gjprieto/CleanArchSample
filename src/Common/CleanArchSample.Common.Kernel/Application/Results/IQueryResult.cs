using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public interface IQueryResult<TResult> : IMessageResult<TResult>
    {
    }
}