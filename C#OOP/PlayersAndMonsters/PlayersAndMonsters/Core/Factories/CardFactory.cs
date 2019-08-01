using PlayersAndMonsters.Core.Factories.Contracts;
using PlayersAndMonsters.Models.Cards.Contracts;
using PlayersAndMonsters.Repositories;
using System;
using System.Linq;
using System.Reflection;

namespace PlayersAndMonsters.Core.Factories
{
    class CardFactory : ICardFactory
    {
        private const string suffix = "Card";
        public ICard CreateCard(string type, string name)
        {
            var cardType = Assembly
                .GetCallingAssembly()
                .GetTypes()
                .FirstOrDefault(x => x.Name == type + suffix);

            if (cardType == null)
            {
                throw new ArgumentException("Card of this type does not exist!");
            }

            var card = (ICard)Activator.CreateInstance(cardType, name);

            return card;

        }
    }
}
