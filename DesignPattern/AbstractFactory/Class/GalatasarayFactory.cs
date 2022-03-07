using AbstractFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Class
{
    public class GalatasarayFactory : TeamAbstractFactory
    {
        public ITeam CreateTeam()
        {
            return new Galatasaray();
        }
    }
}
