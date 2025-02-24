using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndComperator
{
    public class Collection
    {
        List<string> internalList;
        int currIndex;
        public Collection()
        {
            this.currIndex = 0;
         this.internalList = new List<string>();
        }
        public object[] Objects { get { return internalList; } }
        public void Add(object element, int index)
        {
            this.internalList.Add(element);
            currIndex++;
        }
        public IEnumerator<string> GetEnumerator()
        {
            return this.internalList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() 
        {
        return GetEnumerator();
        }

    }
}
