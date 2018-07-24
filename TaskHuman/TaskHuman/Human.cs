using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskHuman
{
    class Human
    {
        //basic information
        protected string FullName;
        protected int Age;
        protected string Firstchromosome { get; } = "X";
        protected virtual string Secondchromosome { get; } = "UnKnown";


        public Human(string FullName, int Age)
        {
            this.FullName = FullName;
            this.Age = Age;
        }
        public virtual string ShowInfAboutPerson()
        {
            return "Fullname: " + FullName + "\tAge: " + Age.ToString();
        }
        public virtual string ShowChromosome()
        {
            return Firstchromosome;
        }

    }
}
