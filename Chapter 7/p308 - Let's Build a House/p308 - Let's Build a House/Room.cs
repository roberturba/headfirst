using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lets_Build_a_House
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + ".";
            }
        }
    }
}