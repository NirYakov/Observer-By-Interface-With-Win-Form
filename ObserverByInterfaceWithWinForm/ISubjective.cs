using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByInterfaceWithWinForm
{
    public interface ISubjective
    {
        void RegisterObserver(IMyObserver i_NewObserver);
        void UnregisterObserver(IMyObserver i_DelObserver);
        void NotifyallObservers(int i_Count);
    }
}
