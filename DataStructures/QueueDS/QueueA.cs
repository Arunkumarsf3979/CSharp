using System.Collections;
namespace QueueDS
{
    public partial class Queue<Type>:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
            i=_front-1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_last-1)
            {
                ++i;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            i=_front-1;
        }
        public object Current{
            get{return _array[i];}
        }

    }
}