using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturent_Management
{
    class Res
    {
        public double rice { get; set; }
        public double am_Cof { get; set; }
        public double af_cof { get; set; }
        public double cp { get; set; }
        public double won { get; set; }
        public double chow { get; set; }
        public double prawn { get; set; }
        public double cutlet { get; set; }

        public Res()
        {
            rice = 0.0;
            am_Cof = 0.0;
            af_cof = 0.0;
            cp = 0.0;
            won = 0.0;
            chow = 0.0;
            prawn = 0.0;
            cutlet = 0.0;
        }
        public Res(double rice, double am_Cof,double af_cof,double cap,double won,double chow,double prawn,double cutlet)
        {

        }
    }
}
