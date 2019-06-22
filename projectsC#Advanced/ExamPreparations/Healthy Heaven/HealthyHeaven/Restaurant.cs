using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HealthyHeaven
{
    class Restaurant
    {
        List<Salad> data;

        public string Name { get; set; }

        public Restaurant(string name)
        {
            this.Name = name;
            data = new List<Salad>();
        }

        public void Add(Salad salad)
        {
            data.Add(salad);
        }

        public bool Buy(string name)
        {
            if (this.data.FirstOrDefault(x => x.Name == name) != null)
            {
                this.data.Remove(this.data.FirstOrDefault(x => x.Name == name));
                return true;
            }
            else
            {
                return false;
            }
        }

        public Salad GetHealthiestSalad()
        {
            return this.data.OrderBy(x => x.GetTotalCalories()).FirstOrDefault();
        }

        public string GenerateMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} have {data.Count} salads:");
            foreach (var salad in data)
            {
                sb.AppendLine(salad.ToString());
            }
            return sb.ToString().Trim();
        }

    }
}
