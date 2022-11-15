namespace QueueDS
{
    public partial class Queue<Type>
    {
        private int _capacity;
        // private int _count;
        private int _front;
        private int _last;
        public int Capacity { get{return _capacity;} }
        public int Count { get{return _last-_front;}}
        private Type[] _array{get;set;}
        public Queue()
        {
            _front=0;
            _last=0;
            // _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public Queue(int size)
        {
            _front=0;
            _last=0;
            // _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Enqueue(Type data)
        {
            if(_front==_capacity)
            {
                GrowSize();
            }
            _array[_last++]=data;
        }
        public Type Dequeue()
        {
            if(!IsEmpty()){
                return _array[_front++];
            }
            return default(Type);
        }
        private void GrowSize()
        {
            _capacity+=4;
            Type[] temp=new Type[_capacity];
            for(int i=_front;i<_last;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public Type Peek()
        {
            return _array[_front];
        }
        public bool IsEmpty()
        {
            if(_front==_last)
            {
                return true;
            }
            return false;
        }
    }
}