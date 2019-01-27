
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Bodypart {

    

    public int BodyPartID;

    public String BodyPartName { get; set; }

    public Decimal MV {get;set;}

    public Decimal MEV { get; set; }

    public Decimal MAV { get; set; }

    public Decimal MRV { get; set; }
    public Bodypart()
    {
        BodyPartID = -1;
        BodyPartName = "Undefined";
        MV = -1;
        MEV = -1;
        MAV = -1;
        MRV = -1;
    }
    public Bodypart(int bpId, String bpName, decimal mv, decimal mev, decimal mav, decimal mrv)
    {
        this.BodyPartID = bpId;
        this.BodyPartName = bpName;
        this.MV = mv;
        this.MEV = mev;
        this.MAV = mav;
        this.MRV = mrv;
    }



}