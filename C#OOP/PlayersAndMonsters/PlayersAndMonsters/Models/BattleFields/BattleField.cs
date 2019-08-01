using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        private const int beginerDamagePoints = 30;
        private const int beginerHealthPoints = 40;

        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            ChekForBeginners(attackPlayer, enemyPlayer);

            attackPlayer.Health += attackPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);
            enemyPlayer.Health += enemyPlayer.CardRepository.Cards.Sum(x => x.HealthPoints);

            while (true)
            {
                var totalDamagePointsAttack = attackPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
                enemyPlayer.TakeDamage(totalDamagePointsAttack);
                if (enemyPlayer.Health == 0)
                {
                    break;
                }
                var totalDamagePointsEnemy = enemyPlayer.CardRepository.Cards.Sum(x => x.DamagePoints);
                attackPlayer.TakeDamage(totalDamagePointsEnemy);
                if (attackPlayer.Health == 0)
                {
                    break;
                }
            }
        }

        private static void ChekForBeginners(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (enemyPlayer.GetType() == typeof(Beginner))
            {
                enemyPlayer.Health += beginerHealthPoints;
                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += beginerDamagePoints;
                }
            }
            if (attackPlayer.GetType() == typeof(Beginner))
            {
                attackPlayer.Health += beginerHealthPoints;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += beginerDamagePoints;
                }
            }

        }
    }
}
