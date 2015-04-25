using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    internal class OpenErpEnumerable<T>: IEnumerable<T>, ICollection<T>
    {
        private List<T> objectList;
        private int[] objectIdList;
        private bool dataLoaded;
        private OpenErpService service;

        public OpenErpEnumerable(OpenErpService service)
        {
            this.service = service;
            objectList = new List<T>();
            dataLoaded = false;
        }

        public OpenErpEnumerable(OpenErpService service, int[] ids):this(service)
        {
            objectIdList = ids;
        }

        private void LoadData()
        {
            if (!dataLoaded)
            {
                if (objectIdList != null && objectIdList.Length > 0)
                {
                    CommandContext context = new CommandContext();
                    context.EntityName = CommandContextFactory.GetOpenErpEntityName(typeof(T));
                    context.EntityType = typeof(T);
                    context.Arguments.Add(new CommandArgument() { Operation = "in", Property = "id", Value = objectIdList });
                    objectList = service.ContextEntities(context).Cast<T>().ToList();
                    dataLoaded = true;
                }
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            LoadData();
            return this.objectList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            LoadData();
            return this.objectList.GetEnumerator();
        }

        public int IndexOf(T item)
        {
            LoadData();
            return this.objectList.IndexOf(item);
        }

        public void Insert(int index, T item)
        {
            LoadData();
            this.objectList.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            LoadData();
            this.objectList.RemoveAt(index);
        }

        public T this[int index]
        {
            get
            {
                return this.objectList[index];
            }
            set
            {
                this.objectList[index] = value;
            }
        }

        public void Add(T item)
        {
            LoadData();
            this.objectList.Add(item);
        }

        public void Clear()
        {
            LoadData();
            this.objectList.Clear();
        }

        public bool Contains(T item)
        {
            LoadData();
            return this.objectList.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            LoadData();
            this.objectList.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            
            get {
                LoadData();
                return objectList.Count(); 
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            LoadData();
            return this.objectList.Remove(item);
        }

        internal OpenErpService GetService()
        {
            return this.service;
        }
    }
}
