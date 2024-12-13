using System;
using System.Collections.Generic;

namespace Tymakov_task
{
    struct Problem
    {
        public Guid IdOfProblem { get; set; }
        public string Description { get; set; }
    }

    public struct Temperament
    {
        private byte level;
        public byte Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > 10)
                {
                    level = 10;
                    return;
                }
                else if (value < 0)
                {
                    level = 0;
                    return;
                }
                level = value;
            }
        }
        private byte wisdom;
        public byte Wisdom
        {
            get { return wisdom; }
            set
            {
                if (value > 1)
                {
                    wisdom = 1;
                    return;
                }
                else if (value < 0)
                {
                    wisdom = 0;
                    return;
                }
                wisdom = value;
            }
        }
    }
    class Dweller
    {
        public string Name { get; set; }
        public Guid PasportID { get; set; }
        public Problem Problem;
        public Temperament Temperament;
        public static Stack<Dweller> Objects = new Stack<Dweller>();

        public Dweller(string name, Guid pasportId, Guid idOfProblem, string problemDiscription, byte tempLevel, byte wisdom)
        {
            Name = name;
            PasportID = pasportId;
            Problem.IdOfProblem = idOfProblem;
            Problem.Description = problemDiscription;
            Temperament.Wisdom = wisdom;
            Temperament.Level = tempLevel;
            Objects.Push(this);
        }
        
    }
}
