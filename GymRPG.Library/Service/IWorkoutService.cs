using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymRPG.Library.Models;

namespace GymRPG.Library.Service
{
    public interface IWorkoutService
    {
        Task<List<Workout>> GetWorkoutList();
        Task <int> AddWorkout(Workout workout);
        Task<int> DeleteWorkout(Workout workout);
        Task<int> UpdateWorkout(Workout workout);

        Task<Workout> GetWorkoutById(int id);
    }
}
