
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Training_record {

  

    public Decimal Tonnage { get; set; }

    public Decimal Reps { get; set; }

    public int TrainingID { get; set; }

    public Decimal EveredgeIntensity { get; set; }

    public Training_record()
    {
    }
    public Training_record(Decimal tonnage, Decimal reps, int trainingId):this(tonnage,reps,trainingId,0)
    {

    }
    public Training_record(Decimal tonnage, Decimal reps, int trainingId, Decimal everedgeIntensity) 
    {
        this.Tonnage = tonnage;
        this.Reps = reps;
        this.TrainingID = trainingId;
        this.EveredgeIntensity = everedgeIntensity;
    }

}