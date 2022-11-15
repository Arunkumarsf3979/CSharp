namespace HotelRoomBooking
{
    public partial class List<Type>
    {
        private int _count;
        private int _capacity;
        private Type[]_array;
        public int Count { get{return _count;}}
        public int  Capacity { get {return _capacity;}}
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
            _capacity=2*_capacity;
            Type[]temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            _array=temp;

        }
        public Type this[int i]{
            get {return _array[i];}
            set {_array[i]=value;}
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
            _count=_count+dataList.Count;
        }
        
        
        
        
    }
}