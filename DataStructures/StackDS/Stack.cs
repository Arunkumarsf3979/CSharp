namespace StackDS
{
    public partial class Stack<Type>
    {
        private int _capacity;
        private int _count;
        public int Capacity { get{return _capacity;} }
        public int Count { get{return _count;}}
        private Type[] _array{get;set;}
        public Stack()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public Stack(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Push(Type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        private void GrowSize()
        {
            _capacity=_count*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type Pop()
        {
            Type temp;
            if(!IsEmpty()){
                temp=_array[_count-1];
                _count--;
                return temp;
            }
            return default(Type);
        }
        public Type Peek()
        {
            return _array[_count-1];
        }
        public bool Contains(Type data)
        {
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsEmpty()
        {
            if(_count==0)
            {
                return true;
            }
            return false;
        }
    }
}