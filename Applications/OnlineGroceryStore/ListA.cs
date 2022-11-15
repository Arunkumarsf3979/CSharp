using System.Collections;
namespace OnlineGroceryStore
{
    public partial class List<Type>:IEnumerable,IEnumerator
    {
        int i;
        public IEnumerator GetEnumerator()
        {
            i=0;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if(i<_count-1)
            {
                i++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            i=-0;
        }
        public object Current{
            get{return _array[i-1];}
        }

    }
}