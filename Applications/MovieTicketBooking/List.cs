namespace MovieTicketBooking
{
    public partial class List<Type>
    {
        private int _count;
        private int _capacity;
        private Type[] _array{get;set;}
        public int Count{get{return _count;}}
        public int Capacity{get{return _capacity;}}
        public Type t
        public List()
        {
            _count=0;
            _capacity=4;
            _array=new Type[_capacity];
        }
        public List(int size)
        {
            _count=0;
            _capacity=size;
            _array=new Type[_capacity];
        }
        public void Add(Type data)
        {
            if(_count==_capacity)
            {
                GrowSize();
            }
            _array[_count]=data;
            _count++;
        }
        public void GrowSize()
        {
            _capacity=_count*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        
    }
}