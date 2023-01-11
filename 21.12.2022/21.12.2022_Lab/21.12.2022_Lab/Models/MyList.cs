using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._12._2022_Lab.Models
{
    internal class MyList<T> : IEnumerable<T>
    {
        static T[] Arr;
        static MyList()
        {
            Arr = new T[0];
        }
        public T this[int index]
        {
            get => Arr[index];
            set => Arr[index] = value;
        }

        public void AddList(T item)
        {
            Array.Resize(ref Arr, Arr.Length + 1);
            Arr[Arr.Length - 1] = item;
        }

        public void RemoveList(T item)
        {
            int index = Array.IndexOf(Arr, item);

            for (int i = index; i < Arr.Length-1; i++)
            {
                Arr[i] = Arr[i + 1];
            }
            Array.Resize(ref Arr, Arr.Length - 1);
        }

        public int Count() => Arr.Length;

        public void Clear()
        {
            Array.Resize(ref Arr, 0);
        }

        public T Find(T el)
        {
            foreach (var item in Arr)
            {
                if (Array.Equals(item,el)) 
                {
                    return item;
                }
            }
            return default(T);
        }

        public List<T> FindAll(T el)
        {
            List<T> list = new List<T>();
            foreach (var item in Arr)
            {
                if (Array.Equals(el,item))
                {
                    list.Add(item);
                }
            }

            return list;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)Arr).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Arr.GetEnumerator();
        }
    }
}
