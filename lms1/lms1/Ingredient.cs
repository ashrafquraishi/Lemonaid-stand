﻿namespace lms1
{
    public class Ingredient
    {
        string name;
        string unit;
        int measurement;

        public Ingredient(string name, string unit)
        {
            this.name = name;
            this.unit = unit;
            measurement = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }
        public int Measurement
        {
            get { return measurement; }
            set { measurement = value; }
        }


    }
}