using System.Collections.Generic;
namespace ListDS
{
    public partial class List<Type>
    {
        public int IndexOf(Type data)
        {
            for(int i=0;i<_count;i++)
            {
                if(_array[i].Equals(data))
                {
                    return i;
                }
            }
            return -1;
        }
        public void Insert(int position,Type data)
        {
            _capacity=_count+1;
            Type[] _temp=new Type[_capacity];
            for(int i=0;i<position;i++)
            {
                _temp[i]=_array[i];
            }
            _temp[position]=data;
            for(int i=position;i<_count;i++)
            {
                _temp[i+1]=_array[i];
            }
            _array=_temp;
            _count++;
        }
        public void RemoveAt(int position)
        {
            for(int i=position;i<_count-1;i++)
            {
                _array[i]=_array[i+1];
            }
            _count--;
        }
        public void Remove(Type data)
        {
            int position=IndexOf(data);
            if(position>-1)
            {
                RemoveAt(position);
            }
        }
        public Type[] ToArray()
        {
            Type[] temp=new Type[_count];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            return temp;
        }
        public void Sort()
        {
            Type temp;
            for(int i=0;i<_count-1;i++)
            {
                for(int j=i+1;j<_count-1;j++)
                {
                    if(IsGreater(_array[i],_array[j]))
                    {
                        temp=_array[i];
                        _array[i]=_array[j];
                        _array[j]=temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value1,Type value2)
        {
            var result=Comparer<Type>.Default.Compare(value1,value2);
            if(result>=0)
            {
                return true;
            }
            else{return false;}
        }
    }
}