using System;
using System.Collections.Generic;
using System.Text;

namespace Asset
{
    class Asset
    {
        private string assetName; // Declare the instance variable

        /*public string AssetName  // Creating the property for 'assetname' instance variable
        {
            get
            {
                return assetName;
            }
            set
            {
                assetName = value;
            }
        }
        */

        public string AssetName { get; set; } //auto-implented property for unsance variable 'assetName'

        private double assetValue;

        public double AssetValue
        {
            get { return assetValue; } // return value
            set // set value if greater than 0
            {
                if (value > 0) { assetValue = value; }
            }
        }

        private double depreciationRate;

        public double DepreciationRate
        {
            get { return depreciationRate; } // return value
            set // set value if greater than 0
            {
                if (value > 0) { depreciationRate = value; }
            }
        }

        public Asset() { } // default constructor

        public Asset(string aname, double avalue, double drate)
        {
            AssetName = aname;
            AssetValue = avalue;
            DepreciationRate = drate;
        }

        // Calculate the depreciation value
        public void CalcDepValue()
        {
            //depvalue = assetvalue * deprate
            //netamount = assetvalue - depvalue

            double depvalue = AssetValue * (DepreciationRate/100);
            AssetValue = AssetValue - depvalue;

            Console.WriteLine($"The {AssetName}'s value depreciated by {depvalue:c}. The net value is {AssetValue:c}.");
        }

    }
}
