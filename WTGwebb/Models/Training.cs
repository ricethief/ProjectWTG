
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Training {
    

    public int TrainingID { get; set; }

    public int Week { get; set; }

    public int Frequency { get; set; }

    public int Intensity { get; set; }

    public int TraineeID { get; set; }

    public Training()
    {
    }
    public Training(int trainingId,int week,int freqiency, int intensity, int traineeId)
    {
        this.TrainingID = trainingId;
        this.Week = week;
        this.Frequency = freqiency;
    }
    
    




}