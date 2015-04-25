using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Jlob.OpenErpNet
{
    public class OpenErpSet<T>:ICollection<T> where T:class, new()
    {

        public ICollection<T> Entities { get; set; }
        public object[] EntitiesId { get; set; }
        public bool DataLoaded { get; set; }
        public OpenErpService Service { get; set; }

        public OpenErpSet(OpenErpService service)
        {
            this.Service = service;
            this.DataLoaded = false;
            this.Entities = new List<T>();
        }

        public OpenErpSet(OpenErpService service, object[] ids):this(service)
        {
            this.EntitiesId = ids;
        }

        public OpenErpSet(OpenErpService service, int[] ids)
            : this(service)
        {
            this.EntitiesId = ids.Cast<object>().ToArray();
        }

        public void LoadData()
        {
            if (!DataLoaded)
            {
                if (EntitiesId != null && EntitiesId.Length > 0)
                {
                    this.DataLoaded = true;
                    //Call for get entities by ids.
                    CommandContext context = new CommandContext();
                    context.EntityName = CommandContextFactory.GetOpenErpEntityName(typeof(T));
                    ResultSet result = this.Service.GetEntityCommand(context, this.EntitiesId);
                    EntityFactory.BuildEntities<T>(Service, result, this);
                }
            }
        }

        public void Add(T item)
        {
            this.Entities.Add(item);
        }

        public void Clear()
        {
            this.Entities.Clear();
        }

        public bool Contains(T item)
        {
            this.LoadData();
            return this.Entities.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            this.LoadData();
            this.Entities.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get {
                LoadData();
                return Entities.Count;
            }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(T item)
        {
            this.LoadData();
            return this.Entities.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            this.LoadData();
            return this.Entities.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            this.LoadData();
            return this.Entities.GetEnumerator();
        }
    }
}
