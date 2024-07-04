using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchSample.Common.Kernel.Application.Messages
{
    public abstract class CommandBase : MessageBase, ICommand
    {
        protected CommandBase() : base() { }
    }
}