using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loot
{
    class Generation
    {
        public static List<string> occupation = new List<string>
        {
            "beggar", "nobleman", "laborer", "ring fighter", "knight"
        };

        public static List<string> town = new List<string>
        {
            "Colonia", "Hemsworth", "Alverton", "Garthram", "Hampstead", "Rivermuth", "Solaria"
        };

        public static List<string> fNameMale = new List<string>
        {
            "Reinald", "Barry", "Nathaniel", "Ermin", "Solomon", "Gilram", "Thelnur", "Doldrak"
        };

        public static List<string> lNameMale = new List<string>
        {
            "Kharmus", "Thalmiir", "Thelren", "Amasu", "Mormar", "Galmiir", "Murdrom"
        };

        public static List<string> fNameFemale = new List<string>
        {
            "Tislen", "Reynwin", "Daeleth", "Erana", "Zyleth", "Cairel", "Aeroph", "Mei"
        };

        public static List<string> lNameFemale = new List<string>
        {
            "Amasu", "Vallynn", "Olathana", "Reywell", "Mormar", "Kharmus"
        };

        public static List<string> reason = new List<string>
        {
            "to get away from family", "due to unforseen consequences", "to explore new places", "to find a job"
        };

        public static List<string> discover = new List<string>
        {
            //Add Content
        };
    }
}
