﻿namespace FootballTeamGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Team
    {
        private string name;
        private List<Player> playerList;
        private Team()
        {
            playerList = new List<Player>();
        }
        public Team(string name)
            :this()
        {
            Name = name;
        }
        public string Name 
        {
            get => this.name;
            set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameCannotBeEmpty);
                name = value;
            }
        }

        public int Rating
            => this.playerList.Count>0 ?
            (int)Math.Round(this.playerList.Average(p => p.OverallRating), 0) : 0;

        public void AddPlayer(Player player)
        {
            playerList.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            Player playerToRemove = this.playerList
                .FirstOrDefault(p => p.Name == playerName);
            if (playerToRemove==null)
            {
                throw new InvalidOperationException(String.Format(
                    ExceptionMessages.RemoveMissingPlayer
                    ,playerName, this.Name));
            }
            this.playerList.Remove(playerToRemove);
        }
        public override string ToString()
        {
            return $"{this.Name} - {this.Rating}";
        }
    }
}
