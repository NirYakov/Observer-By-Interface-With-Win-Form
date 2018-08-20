using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByInterfaceWithWinForm
{
    public interface IMyObserver
    {
        void Update(int i_Count);
    }
}
