using Behavioral.Observer.Subject;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behavioral.Observer.ObserverInterfaces
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    public interface IInvestor
    {
        void Update(Stock stock);
    }
}
