using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tykhomyrova
{

    //create enum for material types
    enum DesktopMaterial
    {
        Oak = 200,
        Laminate = 100,
        Pine = 50,
        Rosewood = 300,
        Veneer = 125
    }

    public class Desk
    {
        //set variables
        public int deskWidth { get; set; }
        public int deskDepth { get; set; }
        public string materialType { get; set; }
        public int numDrawers { get; set; }


        // Constraints for input variables
        public const int minWidth = 24;
        public const int maxWidth = 96;
        public const int minDepth = 28;
        public const int maxDepth = 48;
        public const int minDrawers = 0;
        public const int maxDrawers = 7;

        //moved all functions to DeskQuote.cs for easier communication
    }
}
