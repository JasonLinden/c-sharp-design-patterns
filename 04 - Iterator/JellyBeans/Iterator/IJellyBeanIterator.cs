using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Iterator.JellyBeans.Iterator
{
    /// <summary>
    /// The 'Iterator' interface
    /// </summary>
    interface IJellyBeanIterator
    {
        JellyBean First();
        JellyBean Next();
        bool IsDone { get; }
        JellyBean CurrentBean { get; }
    }
}
