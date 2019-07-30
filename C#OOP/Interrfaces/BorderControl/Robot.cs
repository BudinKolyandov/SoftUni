using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class Robot : IIdentifiable
    {
        private string model;
        public string Id { get; set; }

        public Robot(string model, string id)
        {
            this.model = model;
            this.Id = id;
        }



        public void Checker(string id, string digits)
        {
            if (id.EndsWith(digits))
            {
                Engine.Add(id);
            }
        }
    }
}
