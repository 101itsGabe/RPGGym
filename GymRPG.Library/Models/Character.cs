using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRPG.Library.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string CharClass { get; set; }
        public int Level;
        public int CharacterId { get; set; }

        public List<Workout> Workouts { get; set; }

        public Character() 
        {
            Workouts = new List<Workout>();
        }


    }
}
