﻿namespace HomeWork1
{
    class Mark
    {
        string NameOfSubject;
        int ValueOfMark;
        public int _ValueOfMark
        {
            get { return ValueOfMark; }
            set { ValueOfMark = value; }
        }
        public Mark(string NameOfSubject, int ValueOfMark)
        {
            this.NameOfSubject = NameOfSubject;
            this.ValueOfMark = ValueOfMark;
        }
    }
}
