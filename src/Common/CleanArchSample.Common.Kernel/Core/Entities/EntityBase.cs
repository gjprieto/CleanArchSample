using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Core.Entities
{
    public abstract class EntityBase<TId>
    {
        public TId Id { get; set; }
    }
}