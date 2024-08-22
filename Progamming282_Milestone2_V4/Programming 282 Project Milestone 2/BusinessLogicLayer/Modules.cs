using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming_282_Project_Milestone_2.BusinessLogicLayer
{
    internal class Modules
    {
        int moduleCode;
        string name, description, ytLinks;

        public Modules(int moduleCode, string name, string description, string ytLinks)
        {
            this.ModuleCode = moduleCode;
            this.Name = name;
            this.Description = description;
            this.YtLinks = ytLinks;
        }

        public int ModuleCode { get => moduleCode; set => moduleCode = value; }
        public string Name { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }
        public string YtLinks { get => ytLinks; set => ytLinks = value; }
    }
}
