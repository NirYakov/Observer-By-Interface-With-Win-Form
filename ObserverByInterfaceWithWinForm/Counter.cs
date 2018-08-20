using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverByInterfaceWithWinForm
{
    public class Counter : ISubjective
    {
        private int m_Counter = 0;
        private readonly List<IMyObserver> myObservers = new List<IMyObserver>();

        public void NotifyallObservers(int i_Count)
        {
            foreach (IMyObserver observer in myObservers)
            {
                observer.Update(i_Count);
            }
        }

        public void RegisterObserver(IMyObserver i_NewObserver)
        {
            myObservers.Add(i_NewObserver);
        }

        public void UnregisterObserver(IMyObserver i_DelObserver)
        {
            myObservers.Remove(i_DelObserver);
        }

        public void AddOneToCount()
        {
            m_Counter++;
            NotifyallObservers(m_Counter);
        }

        public void LessOneToCount()
        {
            if (m_Counter > 0)
            {
                m_Counter--;
                NotifyallObservers(m_Counter);
            }
        }
    }
}
