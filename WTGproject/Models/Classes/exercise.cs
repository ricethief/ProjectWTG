
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Exercise {



    public int ExerciseID { get; set; }

    public String ExerciseName { get; set; }

    public Decimal OneRM {get;set;}

    public int TrainingID { get; set; }

    public int Reps { get; set; }
    public int Sets { get; set; }
    

    public Exercise()
    {
        ExerciseID = -1;
        ExerciseName = "Undefined";
        OneRM = -1;
        TrainingID = -1;
    }

   
    public Exercise(int exerciseId, String exerciseName) : this(exerciseId, exerciseName, -1, -1 , -1, -1)
    {
        //premade exersiced has exercise ID,Name. other values(oneRM, trainingId, reps, sets will added later)
    }
    public Exercise(int exerciseId, String exerciseName, Decimal oneRm, int trainingId, int reps, int sets) 
    {
        this.ExerciseID = exerciseId;
        this.ExerciseName = exerciseName;
        this.OneRM = oneRm;
        this.TrainingID = trainingId;
        this.Reps = reps;
        this.Sets = sets;
    }

    



}