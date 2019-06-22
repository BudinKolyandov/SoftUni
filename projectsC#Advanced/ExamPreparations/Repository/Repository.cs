using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Repository
{
    class Repository
    {
        private Dictionary<int, Person> DataField { get;  }

        public Repository()
        {
            this.DataField = new Dictionary<int, Person>();
        }

        public int Count => DataField.Count;
        
        public void Add(Person person)
        {
            DataField.Add(DataField.Count, person);            
        }

        public Person Get(int id)
        {
            Person person = null;
            if (DataField.ContainsKey(id))
            {
                person = DataField[id];
            }
            return person;
        }

        public bool Update(int id, Person newPerson)
        {
            if (!DataField.ContainsKey(id))
            {
                return false;
            }
            DataField.Remove(id);
            DataField.Add(id, newPerson);
            return true;
        }

        public bool Delete(int id)
        {
            if (!DataField.ContainsKey(id))
            {
                return false;
            }
            DataField.Remove(id);
            return true;
        }

    }
}
