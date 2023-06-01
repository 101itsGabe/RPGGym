using GymRPG.Library.Service;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymRPG.Library.Models
{
    public class Character
    {
        
      
        [PrimaryKey, AutoIncrement]
        public int CharacterId { get; set; }
        
        public List<Workout> Workouts { get; set; }
        public string Name { get; set; }
        public string CharClass { get; set; }
        public int Level;
        IWorkoutService WorkoutService;
        public Character() 
        {
            Workouts = new List<Workout>();
            //wos = WorkoutService.Current;
            SetWorkouts();
        }

        public async void SetWorkouts()
        {
            Workouts = await WorkoutService.GetWorkoutList();
        }


    }
}
