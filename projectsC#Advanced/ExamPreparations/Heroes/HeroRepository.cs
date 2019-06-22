using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Heroes
{
    class HeroRepository
    {
        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }

        public int Count
            => this.data.Count;
        
        public void Add(Hero hero)
        {
            data.Add(hero);
        }

        public void Remove(string name)
        {
            Hero heroToRemove = this.data.FirstOrDefault(x => x.Name == name);
            data.Remove(heroToRemove);
        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Strength).FirstOrDefault();
            return hero;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Ability).FirstOrDefault();
            return hero;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero hero = this.data.OrderByDescending(x => x.Item.Intelligence).FirstOrDefault();
            return hero;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in data)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString().Trim();
        }

    }
}
