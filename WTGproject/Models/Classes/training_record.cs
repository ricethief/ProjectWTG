
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Training_record : Training{

  

    public Decimal Tonnage { get; set; }

    public Decimal Reps { get; set; }

    public Training Training { get; set; }

    public Decimal EveredgeIntensity { get; set; }

    public Training_record()
    {
    }

    public Training_record(Training training):this(0,0,training)
    {

    }
    public Training_record(Decimal tonnage, Decimal reps, Training training):this(tonnage,reps,training,0)
    {

    }
    public Training_record(Decimal tonnage, Decimal reps, Training training, Decimal everedgeIntensity) 
    {
        this.Tonnage = tonnage;
        this.Reps = reps;
        this.Training = training;
        this.EveredgeIntensity = everedgeIntensity;
    }

}