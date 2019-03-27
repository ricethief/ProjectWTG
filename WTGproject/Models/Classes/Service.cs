using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WTGwebb.Models
{
    public class Service
    {
        List<Bodypart> bodyparts = new List<Bodypart>();
        List<Exercise> exercises = new List<Exercise>();
        List<Effect> effects = new List<Effect>();
        public Trainee trainee;
        List<Training_record> training_Records = new List<Training_record>();

        public List<Bodypart> LoadBodyPartList()
        {
            //call data of bodyparts from DB [bodyparts.Add();]
            return null;
        }

        public List<Exercise> LoadExerciseList()
        {
            //call data of exercises from DB [exercises.Add();]
            return null;
        }

        public List<Effect> LoadEffect(int bpID, int exerciseID)
        {
            //call data of effects from DB [effects.Add();]
            return null;
        }

        public void SetTrainee(int traineeID)
        {
            //this trainee = call db entity that has same traineeID 
        }

        public void CreateNewTraining(int trainingID, int week, int frequency, int intensity,int traineeID)
        {
           Training tr = new Training(trainingID, week, frequency, intensity, traineeID);
           Training_record trr = new Training_record(tr);
           training_Records.Add(trr);
           //Training_record stores data of Training
        }
        //after creating training, and adding that to training record, we'll calaulate the weekly training for the trainee,
        //and at the end of this function(calculating rep, set, etc), it will store those data inthe training record.
        // (tonage, reps, training)






    }
}