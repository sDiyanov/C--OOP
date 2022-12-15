namespace FootballTeamGenerator
{
    using System;
    
    public class Stats
    {
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public Stats(int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (this.IsStatInvalid(value))
                    throw new ArgumentException(String.Format(
                        ExceptionMessages.StatsShouldBeInTheRange,
                        nameof(Endurance)));
                endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (this.IsStatInvalid(value))
                    throw new ArgumentException(String.Format(
                        ExceptionMessages.StatsShouldBeInTheRange,
                        nameof(Sprint)));
                sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (this.IsStatInvalid(value))
                    throw new ArgumentException(String.Format(
                        ExceptionMessages.StatsShouldBeInTheRange,
                        nameof(Dribble)));
                dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                if (this.IsStatInvalid(value))
                    throw new ArgumentException(String.Format(
                        ExceptionMessages.StatsShouldBeInTheRange,
                        nameof(Passing)));
                passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (this.IsStatInvalid(value))
                    throw new ArgumentException(String.Format(
                        ExceptionMessages.StatsShouldBeInTheRange,
                        nameof(Shooting)));
                shooting = value;
            }
        }

        private bool IsStatInvalid(int value)
         => value < 0 || value > 100;
    }
}
