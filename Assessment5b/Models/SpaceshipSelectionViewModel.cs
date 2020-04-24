using System;
using System.Collections.Generic;

namespace Assessment5b.Models
{
    public class SpaceshipSelectionViewModel
    {
        public List<string> Ships
        {
            get { return Ships; }
            set
            {
                Ships = new List<string>() { "Blue Blazer", "Grass Glider", "Folk Flyer" };
            }
        }
    }
}
