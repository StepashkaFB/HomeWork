using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHuman
{
    class Boy : Human
    {
        public string _FullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        public int _Age
        {
            get { return Age; }
            set { Age = value; }
        }
        private int Height;
        public int _Height
        {
            get { return Height; }
            set { Height = value; }
        }
        private double Weight;
        public double _Weight
        {
            get { return Weight; }
            set { Weight = value; }
        }
        protected override string Secondchromosome { get; } = "Y";

        public Boy(int Height, double Weight, string FullName, int Age) : base(FullName, Age)
        {
            this.Height = Height;
            this.Weight = Weight;
        }
        public override string ShowInfAboutPerson()
        {
            return base.ShowInfAboutPerson() + "\tHeight: " + Height.ToString();
        }
        public override string ShowChromosome()
        {
            return base.ShowChromosome() + Secondchromosome + " " + "-- this is Boy";
        }
        public int ShowAgeYearInMonth()
        {
            return 12 * Age;
        }
        public double ShowIndexMassBody()
        {
            return Weight / (Math.Pow((double)Height / 100, 2));
        }
    }
}
