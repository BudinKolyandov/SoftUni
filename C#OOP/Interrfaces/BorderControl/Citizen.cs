
namespace BorderControl
{
    class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        public string id;

        public string Id { get; set; }

        public Citizen(string name, int age, string id)
        {
            this.name = name;
            this.age = age;
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
