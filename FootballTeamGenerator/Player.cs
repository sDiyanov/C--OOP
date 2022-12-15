﻿namespace FootballTeamGenerator
{
    using System;

    public class Player
    {
        private string name;

      
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Stats = new Stats(endurance, sprint, dribble, passing, shooting);
            
        }
        public string Name
        {
            get => this.name;
            private set
            {
                if (String.IsNullOrEmpty(value) || String.IsNullOrWhiteSpace(value))
                    throw new ArgumentException(ExceptionMessages.NameCannotBeEmpty);
                name = value;
            }
        }

        public Stats Stats { get; private set; }

        public double OverallRating
            => (Stats.Endurance + Stats.Sprint + Stats.Dribble + Stats.Passing + Stats.Shooting) / 5.0;

    }
}
