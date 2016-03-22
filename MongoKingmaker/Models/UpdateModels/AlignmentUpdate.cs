using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MongoKingmaker.Models.UpdateModels
{
    public class AlignmentUpdate
    {
        public AlignmentUpdate()
        {
            left = new Alignment()
            {
                name = string.Empty,
                kingdom_attributes = new Kingdom_Attributes() { }
            };

            right = new Alignment()
            {
                name = string.Empty,
                kingdom_attributes = new Kingdom_Attributes() { }
            };
        }

        public string id;

        public Alignment left;

        public Alignment right;

    }
}