using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hitech.Business
{
    public class GenericList<U, T>
    {
        private SortedList<U, T> MyList;

        public GenericList()
        {
            MyList = new SortedList<U, T>();
        }

        //public T this[U key]
        //{
        //    set
        //    {
        //        if (this.MyList.ContainsKey(key))
        //        {
        //            this.MyList[key] = value;
        //        }
        //        else
        //        {
        //            this.MyList.Add(key, value);
        //        }
        //    }
        //    get
        //    {
        //        if (this.MyList.ContainsKey(key))
        //        {
        //            return this.MyList[key];
        //        }
        //        //default(T) = null, if T is Object
        //        //default(T) = 0, if T is int
        //        return default(T);
        //    }
        //}//End of indexer
        //------------------------------------------------
        public T this[int position]
        {
            set
            {
                if (position < 0 || position >= this.MyList.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                U key = this.MyList.Keys[position];
                this.MyList[key] = value;
            }
            get
            {
                if (position < 0 || position >= this.MyList.Count)
                {
                    throw new IndexOutOfRangeException();
                }
                U key = this.MyList.Keys[position];

                return this.MyList[key];
            }
        }//End of Indexer

        //------------------------------------------------
        // Getters and setters
        //------------------------------------------------
        public T GetByKey(U key)
        {
            if (this.MyList.ContainsKey(key))
            {
                return this.MyList[key];
            }
            //default(T) = null, if T is Object
            //default(T) = 0, if T is int
            return default(T);
        }
        //------------------------------------------------
        public void SetByKey(U key, T value)
        {
            if (this.MyList.ContainsKey(key))
            {
                this.MyList[key] = value;
            }
            else
            {
                this.MyList.Add(key, value);
            }
        }
        //------------------------------------------------
        public T GetByPosition(int position)
        {
            if (position < 0 || position >= this.MyList.Count)
            {
                throw new IndexOutOfRangeException();
            }
            U key = this.MyList.Keys[position];

            return this.MyList[key];
        }
        //------------------------------------------------
        public void SetByKey(int position, T value)
        {
            if (position < 0 || position >= this.MyList.Count)
            {
                throw new IndexOutOfRangeException();
            }
            U key = this.MyList.Keys[position];
            this.MyList[key] = value;
        }
        //------------------------------------------------
        // End of getters and setters
        //------------------------------------------------

        //------------------------------------------------
        public int GetCount()
        {
            return this.MyList.Count;
        }
        //------------------------------------------------
        public bool Add(U key, T value)
        {
            if (this.MyList.ContainsKey(key) == false)
            {
                this.MyList.Add(key, value);
                return true;
            }
                      
            return false;
        }
        //------------------------------------------------
        public bool Contains(U key)
        {
            return this.MyList.ContainsKey(key);
        }
        //------------------------------------------------
        public void Remove(U key)
        {
            if (this.MyList.ContainsKey(key) == true)
            {
                this.MyList.Remove(key);
            }
        }
        //-----------------------------------------
        public override string ToString()
        {
            string list = "";
            foreach (U key in this.MyList.Keys)
            {
                T obj = this.MyList[key];
                list += obj.ToString() + "\n";
            }
            return list;
        }
    }
}
