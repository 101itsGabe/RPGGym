using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymRPG.Library.Models;

namespace GymRPG.Library.Service
{
    public class WorkoutService
    {
        public static WorkoutService _instance;
        public List<Workout> Workouts { get; private set; }

        public WorkoutService()
        {
            Workouts = new List<Workout>();
            Workouts.Add(MakeWorkout("Bicep Curl"));
        }

        public static WorkoutService Current
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new WorkoutService();
                }
                return _instance;
            }
        }

        public Workout MakeWorkout(string s)
        {
            var curWork = new Workout
            {
                WorkoutName = s,
                WOLevel = 0,
                curType = WorkoutType.Arms
            };

            return curWork;
        }
    }
}
