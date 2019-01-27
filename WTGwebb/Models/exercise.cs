
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Exercise {



    public int ExerciseID { get; set; }

    public String ExerciseName { get; set; }

    public Decimal OneRM {get;set;}

    public int TrainingID { get; set; }
    

    public Exercise()
    {
        ExerciseID = -1;
        ExerciseName = "Undefined";
        OneRM = -1;
        TrainingID = -1;
    }

    public Exercise(int exerciseId, String exerciseName, Decimal oneRm) : this(exerciseId, exerciseName, oneRm, -1)
    {

    }
    public Exercise(int exerciseId, String exerciseName, Decimal oneRm, int trainingId) 
    {
        this.ExerciseID = exerciseId;
        this.ExerciseName = exerciseName;
        this.OneRM = oneRm;
        this.TrainingID = trainingId;
    }

    



}