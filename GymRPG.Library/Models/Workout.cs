using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRPG.Library.Models
{
    public class Workout
    {
        [PrimaryKey,AutoIncrement] 
        public int Id { get; set; }
        public WorkoutType curType { get; set; }
        public string WorkoutName { get; set; }
        public int WOLevel { get; set; }
    }
}

public enum WorkoutType
{
    Arms = 0,
    Chest = 1,
    Legs = 2,
    Cardio = 3
}
