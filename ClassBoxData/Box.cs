using System;
using System.Collections.Generic;
using System.Text;

namespace ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public double Length 
        {
            get { return this.length; }
            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(
                    ExceptionMessages.BoxParameterCannotBeZeroOrNegative
                    , nameof(this.Length)));
                length = value;
            }
        }
        public double Width
        {
            get { return this.width; }
            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(
                    ExceptionMessages.BoxParameterCannotBeZeroOrNegative
                    , nameof(this.Width)));
                width = value;
            }
        }
        public double Height
        {
            get { return this.height; }
            private set
            {
                if (value <= 0) throw new ArgumentException(String.Format(
                    ExceptionMessages.BoxParameterCannotBeZeroOrNegative
                    , nameof(this.Height)));
                height = value;
            }
        }
        public double SurfaceArea()
            => 2 * Length * Width + LateralSurfaceArea();

        public double LateralSurfaceArea()
            => 2 * Length * Height + 2 * Width * Height;
        
        public double Volume()
            => Length * Width * Height;

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Surface Area - {SurfaceArea():f2}")
                .AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}")
                .AppendLine($"Volume - {Volume():f2}");

            return sb.ToString().TrimEnd();
        }
    }
}
