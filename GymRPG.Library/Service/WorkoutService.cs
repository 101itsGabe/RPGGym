using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymRPG.Library.Models;
using SQLite;
using GymRPG.Library.Service;

namespace GymRPG.Library.Service
{
    public class WorkoutService : IWorkoutService
    {
        private SQLiteAsyncConnection _dbConn;

        public WorkoutService()
        {
            SetUpDb();
        }



        private async void SetUpDb()
        {
            if (_dbConn == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TaskItem.db3");
                _dbConn = new SQLiteAsyncConnection(dbPath);
                await _dbConn.CreateTableAsync<Workout>();
            }
        }

        public Task<int> AddWorkout(Workout workout)
        {
            return _dbConn.InsertAsync(workout);
        }

        public Task<int> DeleteWorkout(Workout workout)
        {
            return _dbConn.DeleteAsync(workout);
        }

        public Task<List<Workout>> GetWorkoutList() 
        {
            return _dbConn.Table<Workout>().ToListAsync();
        }

        public Task<int> UpdateWorkout(Workout workout) 
        {
            return _dbConn.UpdateAsync(workout);
        }
        
        public Task<Workout> GetWorkoutById(int id)
        {
            var curWorkout = _dbConn.Table<Workout>().FirstOrDefaultAsync(w => w.Id == id);
            return curWorkout;
        }

        
    }
}
