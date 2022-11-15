using System.Collections.Generic;
namespace ArrayListDS
{
    public partial class ArrayList
    {
        public int IndexOf(dynamic data)
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
        public void Insert(int position,dynamic data)
        {
            _capacity=_count+1;
            dynamic[] _temp=new dynamic[_capacity];
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
        public void Remove(dynamic data)
        {
            int position=IndexOf(data);
            if(position>-1)
            {
                RemoveAt(position);
            }
        }
        public dynamic[] ToArray()
        {
            dynamic[] temp=new dynamic[_count];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_array[i];
            }
            return temp;
        }
        public void Sort()
        {
            dynamic temp;
            for(int i=0;i<_count-1;i++)
            {
                for(int j=i+1;j<_count;j++)
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
        public bool IsGreater(dynamic value1,dynamic value2)
        {
            var result=Comparer<dynamic>.Default.Compare(value1,value2);
            if(result>=0)
            {
                return true;
            }
            else{return false;}
        }
    }
}