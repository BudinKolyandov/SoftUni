using PlayersAndMonsters.Models.Players.Contracts;
using PlayersAndMonsters.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly List<IPlayer> players;

        public PlayerRepository()
        {
            players = new List<IPlayer>();
        }
        public int Count
            => this.Players.Count;

        public IReadOnlyCollection<IPlayer> Players
            => this.players.AsReadOnly();

        public void Add(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            bool playerExist = this.players.Any(x => x.Username == player.Username);
            if (playerExist)
            {
                throw new ArgumentException($"Player {player.Username} already exists!");
            }
            this.players.Add(player);

        }
        public IPlayer Find(string username)
        {
            return this.players.FirstOrDefault(x => x.Username == username);
        }
        public bool Remove(IPlayer player)
        {
            if (player == null)
            {
                throw new ArgumentException("Player cannot be null");
            }
            var isRemoved = this.players.Remove(player);
            return isRemoved;
        }
    }
}
