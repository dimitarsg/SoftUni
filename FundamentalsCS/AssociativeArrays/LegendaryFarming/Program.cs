using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> materialsObtained = new Dictionary<string, List<int>>();
            Dictionary<string, int> materialsCalculated = new Dictionary<string, int>();

            materialsCalculated.Add("shards", 0);
            materialsCalculated.Add("motes", 0);
            materialsCalculated.Add("fragments", 0);

            bool legendaryItemObtained = false;
            string legendaryItemName = string.Empty;

            while (true)
            {
                if (legendaryItemObtained)
                {
                    break;
                }

                string[] inputMaterial = Console.ReadLine()
                    .ToLower()
                    .Split(' ', (char)StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int i = 0; i < inputMaterial.Length; i += 2)
                {
                    string materialName = inputMaterial[i + 1];
                    int materialQty = int.Parse(inputMaterial[i]);

                    if (!materialsObtained.ContainsKey(materialName))
                    {
                        List<int> newMaterialQty = new List<int>();
                        newMaterialQty.Add(materialQty);
                        materialsObtained.Add(materialName, newMaterialQty);
                    }
                    else
                    {
                        materialsObtained[materialName].Add(materialQty);
                    }

                    int currentMaterialSum = materialsObtained[materialName].Sum();

                    if (!materialsCalculated.ContainsKey(materialName))
                    {
                        materialsCalculated.Add(materialName, currentMaterialSum);
                    }
                    else
                    {
                        materialsCalculated[materialName] = currentMaterialSum;
                    }

                    if (materialName == "shards" && currentMaterialSum >= 250)
                    {
                        legendaryItemObtained = true;
                        legendaryItemName = "Shadowmourne";
                        materialsCalculated[materialName] -= 250;
                        break;
                    }
                    else if (materialName == "fragments" && currentMaterialSum >= 250)
                    {
                        legendaryItemObtained = true;
                        legendaryItemName = "Valanyr";
                        materialsCalculated[materialName] -= 250;
                        break;
                    }
                    else if (materialName == "motes" && currentMaterialSum >= 250)
                    {
                        legendaryItemObtained = true;
                        legendaryItemName = "Dragonwrath";
                        materialsCalculated[materialName] -= 250;
                        break;
                    }
                }
            }

            Console.WriteLine($"{legendaryItemName} obtained!");

            foreach (var material in materialsCalculated)
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}

