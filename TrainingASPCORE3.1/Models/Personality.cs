using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrainingASPCORE3._1.Models
{
    public class Personality
    {
        public String AstroSign { get; set; }
        public String HairColor { get; set; }
        public String FavDino { get; set; }

        public Personality()
        {
            this.AstroSign = String.Empty;
            this.HairColor = String.Empty;
            this.FavDino = String.Empty;
        }

        public Personality(String AstroSign, String HairColor, String FavDino)
        {
            this.AstroSign = AstroSign;
            this.HairColor = AstroSign;
            this.FavDino = AstroSign;
        }

    }




}
