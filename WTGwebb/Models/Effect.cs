
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Effect {

   

    public Decimal VolumeResponse { get; set; }
    public int ExerciseID { get; set; }
    public int BodypartID { get; set; }

    public Effect()
    {
        VolumeResponse = -1;
        ExerciseID = -1;
        BodypartID = -1;
    }
    public Effect(Decimal volumeResponse, int exerciseId, int bodypartId)
    {
        this.VolumeResponse = volumeResponse;
        this.ExerciseID = exerciseId;
        this.BodypartID = bodypartId;
    }
}