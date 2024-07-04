using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Results
{
    public class QueryResult<TResult> : MessageResult<TResult>, IQueryResult<TResult>
    {
        public QueryResult(TResult result) : base(result)
        {
        }

        public QueryResult(bool isCompleted, bool isSuccess) : base(isCompleted, isSuccess)
        {
        }

        public QueryResult(bool isCompleted, bool isSuccess, string[] errorMessages) : base(isCompleted, isSuccess, errorMessages)
        {
        }
    }
}