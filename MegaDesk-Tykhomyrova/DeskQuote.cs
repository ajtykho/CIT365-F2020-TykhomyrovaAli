using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tykhomyrova
{
    public class DeskQuote
    {

        //variables from form and create new object
    /*    private Desk newDesk = new Desk();
        private DeskQuote newDeskQuote = new DeskQuote();*/
        public string customerName;
        public int rushDays;
        public DateTime submissionDate;

        //variables for functions to save numbers
        public int areaPrice;
        public int materialPrice;
        public int rushPrice;
        public int quoteTotal;
        public int drawerTotal;
        public int deskArea;

        //base prices for certain objects
        public const int basePrice = 200;
        public const int averageSize = 1000;
        public const int drawerBasePrice = 50;

        //calculate surface area
        private int calcdeskArea(int width, int depth)
        {
            //get depth and width
            this.deskWidth = width;
            this.deskDepth = depth;
            //calculate area and return
            deskArea = newDesk.deskWidth * newDesk.deskDepth;
            return deskArea;
        }

        //calculate area cost
        private int calcAreaCost(int deskArea)
        {
            if (deskArea <= 1000)
            {
                areaPrice = averageSize;
            }
            else
            {
                areaPrice = averageSize + (deskArea - averageSize);
            }

            return areaPrice;
        }

        //calculate material cost
        private int CalcMaterialCost(string material)
        {
            newDesk.materialType = material;

            switch (newDesk.materialType)
            {
                case "Oak":
                    materialPrice = 200;
                    break;

                case "Laminate":
                    materialPrice = 100;
                    break;

                case "Pine":
                    materialPrice = 50;
                    break;

                case "Rosewood":
                    materialPrice = 300;
                    break;

                case "Veneer":
                    materialPrice = 125;
                    break;
            }
            return materialPrice;
        }

        //calculate rush fee
        private int CalcRushORderCost(int rushDays, int deskArea)
        {
            if (deskArea < 1000)
            {
                switch (rushDays)
                {
                    case 3:
                        rushPrice = 60;
                        break;
                    case 5:
                        rushPrice = 40;
                        break;
                    case 7:
                        rushPrice = 30;
                        break;
                    case 14:
                        rushPrice = 0;
                        break;
                }
            }
            else if (deskArea > 1000 && deskArea < 2000)
            {
                switch (rushPrice)
                {
                    case 3:
                        rushPrice = 70;
                        break;
                    case 5:
                        rushPrice = 50;
                        break;
                    case 7:
                        rushPrice = 35;
                        break;
                    case 14:
                        rushPrice = 0;
                        break;
                }
            }
            else if (deskArea > 2000)
            {
                switch (rushPrice)
                {
                    case 3:
                        rushPrice = 80;
                        break;
                    case 5:
                        rushPrice = 60;
                        break;
                    case 7:
                        rushPrice = 40;
                        break;
                    case 14:
                        rushPrice = 0;
                        break;
                }
            }
            return rushPrice;
        }


        public DeskQuote()
        {

            drawerTotal = newDesk.numDrawers * drawerBasePrice;
            quoteTotal = basePrice + areaPrice + drawerTotal + materialPrice + rushPrice;

        }


    }
}
