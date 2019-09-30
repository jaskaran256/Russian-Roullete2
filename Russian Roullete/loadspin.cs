using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Russian_Roullete
{
   public class loadspin     //below code is loadspin class 
    {
        public int spingunchamber;  //coding is for int
        public int allbullet = 6; // coding for loding 6 bullets 
        public int gunloder = 0;
        public int winscore = 0;
        public int awaypoint;
        
        public int slectnumber( )
        {
            Random objrandom = new Random();

            spingunchamber = objrandom.Next(1, 6); // coding for spin chamber loding gun six guns 

            return spingunchamber;
        }
    }
}
