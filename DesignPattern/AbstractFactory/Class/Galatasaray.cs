using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    public class Galatasaray : ITeam
    {
        public string getStadium()
        {
            return "Ali Sami Yen";
        }

        public string getTeamColor()
        {
            return "sarı kırmızı";
        }
    }
}
