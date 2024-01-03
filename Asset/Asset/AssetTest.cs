using System;

namespace Asset
{
    class AssetTest
    {
        static void Main(string[] args)
        {
            Asset asset1 = new Asset("Car", 20000, 5); // Create new asset, asset1

            Console.WriteLine($"----Creating Asset 1-----");
            Console.WriteLine($"The name of my asset is: {asset1.AssetName}. Its value is {asset1.AssetValue:c}. The dep rate is {asset1.DepreciationRate}.");
            asset1.CalcDepValue();

            Asset asset2 = new Asset("House", 2000000, 3); // Create new asset, asset2

            Console.WriteLine($"----Creating Asset 2-----");
            Console.WriteLine($"The name of my asset is: {asset2.AssetName}. Its value is {asset2.AssetValue:c}. The dep rate is {asset2.DepreciationRate}.");
            asset2.CalcDepValue();
        }
    }
}
