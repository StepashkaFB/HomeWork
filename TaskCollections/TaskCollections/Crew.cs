using System;
using System.Collections;
using System.Collections.Generic;

namespace TaskCollections
{
    class Crew : IList, IComparer<Worker>
    {
        public Worker[] ContentsWorker;
        private int _count;

        public Crew(int Amount)
        {
            ContentsWorker = new Worker[Amount];
            _count = 0;
        }

        //Implementation IComparer
        public int Compare(Worker worker1, Worker worker2)
        {
            return (worker1.Position.CompareTo(worker2.Position));
        }

        //Implementation IList
        public IEnumerator GetEnumerator()
        {
            for (int Counter = 0; Counter < ContentsWorker.Length; Counter++)
            {
                yield return "FullName: " + ContentsWorker[Counter].FullName + " -- Post: " +
                    ContentsWorker[Counter].Position + " -- Position: " +
                    ContentsWorker[Counter].Post;
            }
        }

        public int Add(object value)
        {
            if (_count < ContentsWorker.Length)
            {
                ContentsWorker[_count] = (Worker)value;
                _count++;
                return (_count - 1);
            }
            else
            {
                return -1;
            }
        }
        
        public void Clear()
        {
            _count = 0;
        }
        public bool Contains(object value)
        {
            bool inList = false;
            for (int Counter = 0; Counter < Count; Counter++)
            {
                if (ContentsWorker[Counter] == value)
                {
                    inList = true;
                    break;
                }
            }
            return inList;
        }

        public int IndexOf(object value)
        {
            int itemIndex = -1;
            for (int Counter = 0; Counter < Count; Counter++)
            {
                if (ContentsWorker[Counter] == value)
                {
                    itemIndex = Counter;
                    break;
                }
            }
            return itemIndex;
        }

        public void Insert(int index, object value)
        {
            if ((_count + 1 <= ContentsWorker.Length) && (index < Count) && (index >= 0))
            {
                _count++;

                for (int Counter = Count - 1; Counter > index; Counter--)
                {
                    ContentsWorker[Counter] = ContentsWorker[Counter - 1];
                }
                ContentsWorker[index] = (Worker)value;
            }
        }

        public bool IsFixedSize
        {
            get
            {
                return true;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Remove(object value)
        {
            RemoveAt(IndexOf(value));
        }

        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int Counter = index; Counter < Count - 1; Counter++)
                {
                    ContentsWorker[Counter] = ContentsWorker[Counter + 1];
                }
                _count--;
            }
        }

        public object this[int index]
        {
            get
            {
                return ContentsWorker[index];
            }
            set
            {
                ContentsWorker[index] = (Worker)value;
            }
        }

        // ICollection Members
        public void CopyTo(Array array, int index)
        {
            int TempIndex = index;
            for (int Counter = 0; Counter < Count; Counter++)
            {
                array.SetValue(ContentsWorker[Counter], TempIndex);
                TempIndex++;
            }
        }

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public bool IsSynchronized
        {
            get
            {
                return false;
            }
        }
        public object SyncRoot
        {
            get
            {
                return this;
            }
        }
    }
}
