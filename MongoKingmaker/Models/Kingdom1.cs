using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB;

namespace MongoKingmaker.Models
{
    public class Kingdom
    {
        public object _id { get; set; }
        public string name { get; set; }
        public List<Alignment> alignments { get; set; }
        public KingdomChecks kingdomchecks { get; set; }
        public Leadership[] leadership { get; set; }
        public Hex[] hexes { get; set; }
    }

    public class KingdomChecks
    {
        public float Economy { get; set; }
        public float Loyalty { get; set; }
        public float Stability { get; set; }
        public float Control_DC { get; set; }
        public float Treasury { get; set; }
        public float Unrest { get; set; }
        public float Consumption { get; set; }
        public float Size { get; set; }
    }

    public class Alignment
    {
        public string name { get; set; }
        public Effect effect { get; set; }
    }

    public class Effect
    {
        public float stablity { get; set; }
        public float economy { get; set; }
        public float loyalty { get; set; }
        public float consumption { get; set; }
    }

    public class Leadership
    {
        public string name { get; set; }
        public string role { get; set; }
        public float attribute { get; set; }
        public bool leadership { get; set; }
        public Effect[] effect { get; set; }
        public Penalty[] penalty { get; set; }
    }

    public class Penalty
    {
        public float unrest { get; set; }
    }

    public class Hex
    {
        public string location { get; set; }
        public string terrain { get; set; }
        public Terrain_Improvements[] terrain_Improvements { get; set; }
        public Special_Terrain[] special_terrain { get; set; }
        public Settlement[] settlements { get; set; }
    }

    public class Terrain_Improvements
    {
        public string name { get; set; }
        public Effect effect { get; set; }
        public float[] cost { get; set; }
        public string[] terrain { get; set; }
    }

    public class Special_Terrain
    {
        public string name { get; set; }
        public Effect effect { get; set; }
    }

    public class Settlement
    {
        public string name { get; set; }
        public District[] districts { get; set; }
    }

    public class District
    {
        public string name { get; set; }
        public Bulding[] buldings { get; set; }
    }

    public class Bulding
    {
        public string name { get; set; }
        public float[] cost { get; set; }
        public Effect[] effect { get; set; }
        public Special[] special { get; set; }
    }

    public class Special
    {
        public float base_value { get; set; }
    }

}