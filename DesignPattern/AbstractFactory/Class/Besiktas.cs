using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    public class Besiktas : ITeam
    {
        public string getStadium()
        {
            return "Vodafone Park";
        }

        public string getTeamColor()
        {
            return "Siyah-Beyaz";
        }
    }
}
