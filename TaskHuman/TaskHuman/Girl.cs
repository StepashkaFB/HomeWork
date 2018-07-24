using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHuman
{
    class Girl : Human
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
        private bool UseCosmetics;
        public bool _UseCosmetics
        {
            get { return UseCosmetics; }
            set { UseCosmetics = value; }
        }
        private int Height;
        public int _Height
        {
            get { return Height; }
        }
        protected override string Secondchromosome { get; } = "X";

        public Girl(int Height, string FullName, int Age) : base(FullName, Age)
        {
            this.Height = Height;

        }
        public override string ShowInfAboutPerson()
        {
            return base.ShowInfAboutPerson() + "\tHeight: " + Height.ToString();
        }
        public override string ShowChromosome()
        {
            return base.ShowChromosome() + Secondchromosome + " " + "-- this is Girl";
        }
        public double ShowHeightInMeters()
        {
            return (double)Height / 100;
        }
    }
}
