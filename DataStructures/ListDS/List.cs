namespace ListDS
{
    public partial class List<Type>
    {
        private int _capacity;
        private int _count;
        public int Capacity { get{return _capacity;} }
        public int Count { get{return _count;}}
        public Type this[int i]
        {
            get{return _array[i];}
            set{_array[i]=value;}
        }
        private Type [] _array{get;set;}
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
            _capacity=_capacity*2;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;
        }
        public void AddRange(List<Type> dataList)
        {
            Type[] temp=new Type[_count+dataList.Count];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            for(int i=0;i<dataList.Count;i++)
            {
                temp[_count+i]=dataList[i];
            }
            _array=temp;
            _count=_count+dataList.Count-1;
            // return _array;
        }
        
    }
}