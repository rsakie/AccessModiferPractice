using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierPractice
{
    class Cellphone
    {
        private string make;
        private bool hasCase;
        private int memorySize;

        public string Make
        {
            get { return this.make; }
            //set { this.make = value; }
        }
        public bool HasCase
        {
            get { return this.hasCase = false; }
        }
        public int MemorySize
        {
            get { return this.memorySize; }
            set { this.memorySize = value; }
        }
        public Cellphone(string make, bool hasCase, int memorySize)
        {
            this.make = make;
            this.hasCase = hasCase;
            this.memorySize = memorySize;
        }
        public void Maker()
        {
            this.make = "samsung";
            this.hasCase = false;
        }
        public double Memory()
        {
            memorySize = 150;
            return memorySize;
        }
    }
}
