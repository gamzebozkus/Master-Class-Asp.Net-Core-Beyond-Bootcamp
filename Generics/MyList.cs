using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()//constructor ismi class ile aynı olur
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items=new T[items.Length+1];//burada newleme yaptığımız için önceki elemanların referans numaraları uçmaması için bir önceki satırda temparray içerine koyduk.
            for(int i=0;i<tempArray.Length;i++)
            {
                items[i] = tempArray[i];//burada items eski referans değerlerine ulaşmış oldu.
            }
            items[items.Length-1] = item;
        
        }
    }
}
