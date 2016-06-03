using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSuperProject.BattleDrow
{
    interface IHero
    {
        string Name { get; set; }
        string Char_Class { get; set; }
        int STR { get; set; }
        int INT { get; set; }
        int DEX { get; set; }
        int CHA { get; set; }
        int VIT { get; set; }
        int DEF { get; set; }
        
    }
}
