using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace CChavezP3
{
    internal class LogoOrderItem
    {
        //-------------------------------------
        //Private Fields
        //-------------------------------------
        // Declare all fields as private! 
        private bool hasLogo;
        private string itemType;
        private int numColors;
        private int numItems;
        private string text;

        // variables I added to make this work
        private int orderNum;
        //-------------------------------------
        //Constructors
        //-------------------------------------
        //  Add three constructors to your LogoOrderItem class. 
        public LogoOrderItem()
            : this(false, -1, "mug", 0, 0, "")
        {
            //  Default values for chaining should be the following:
            //•	itemID: -1
            //•	itemType: “mug”
            //•	numColors: 0
            //•	numItems: 0
            //•	hasLogo: false

        }
        public LogoOrderItem(bool hasLogo, string text)
            : this(hasLogo, -1, "mug", 0, 0, text)
        {

        }
        public LogoOrderItem(bool hasLogo, int itemID, string itemType, int numColors, int numItems, string text)
        {
            HasLogo = hasLogo;
            ItemID = itemID;
            ItemType = itemType;
            NumColors = numColors;
            NumItems = numItems;
            Text = text;

        }
        //-------------------------------------
        //Properties
        //-------------------------------------
        //  property I added to make this all woork
        public int OrderNum { get; set; }
        public bool HasLogo
        {
            get
            {
                return hasLogo;
            }
            set
            {
                hasLogo = value;
                Calc();
            }
        }

        //  Include the following auto-properties:
        //  An int for item ID
        public int ItemID { get; set; }
        public string ItemType
        {
            get
            {
                return itemType;
            }
            set
            {
                itemType = value;
                Calc();
            }
        }
        public int NumColors
        {
            get
            {
                return numColors;
            }
            set
            {
                numColors = value;
                Calc();
            }
        }
        public int NumItems
        {
            get
            {
                return numItems;
            }
            set
            {
                numItems = value;
                Calc();
            }
        }
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                Calc();
            }
        }
        //  Include the following read-only auto-properties: 
        //  A read only decimal for the total price of all items with all options
        //  NOT DONE
        public decimal Price { get; set; }

        //-------------------------------------
        //Properties
        //-------------------------------------
        private void Calc()
        {
            //  Write a private, void and parameterless Calculate method called Calc.
            //  This method will calculate the price of the logo item based on the
            //  type of item whether or not it is a graphic or text only logo, number
            //  of colors and number of items.Make sure to read the customers’
            //  requirements above carefully and implement their business rules into
            //  the calculate method correctly.

            // Set Base price
            int itemId = ItemID;
            if (itemId == 1)
            {
                // mug
                Price = 3.50M;
                
            }
            else if (itemId == 2)
            {
                //  usb
                Price = 4.00M;

            }
            else if (itemId == 3)
            {
                // pen
                Price = 1.00M;
            }

            // increase price if text present
            if (Text != "") 
            {
                Price = Price + 0.05M;
            }
            // Increase price if logo present
            if (hasLogo = true)
            {
                Price = Price + 0.10M;
                //  4.Note that if there is no logo the customer should not be charged for any colors.
                //  This could be handled a number of ways, either in the classes calculate method
                //  or by making sure the number of colors is set to 0 if logo is not checked.
                //  You decide best approach.
                Price = Price + (NumColors * 0.03M);
            }


        }
        public string GetOrderSummery()
        {
            decimal fullPrice = Price * NumItems;
            if (HasLogo = true)
            {
                string summary =
                    $"Order num {OrderNum}: {NumItems} {ItemType} with {NumColors} color logo with the following text:{Text}Price per unit:${Price}\nTotal order price:${fullPrice}";
                    return summary;
            }
            else
            {
                string summary =
                    $"Order num {OrderNum}\n{NumItems} {ItemType} with no logo but with the following text: {Text} Price: ${fullPrice}";
                return summary;
            }
        }
    }
}
