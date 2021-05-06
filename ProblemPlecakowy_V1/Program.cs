using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProblemPlecakowy_V1
{
    class KnapsackProblem
    {
        public class Item
        {
            public string Name { get; set; }
            public int Weigth { get; set; }
            public int Value { get; set; }

            public Item(string name, int weigth, int value)
            {
                this.Name = name;
                this.Weigth = weigth;
                this.Value = value;
            }

            public override string ToString()
            {
                return this.Name + " -> w: " + this.Weigth + ", v: " + this.Value;
            }
        }

        static void Main()
        {
            var sw = new Stopwatch();
            sw.Start();
            var ks = new KnapsackBruteForce
            {
                myBagCapacity = 400,
                myItems = new Item[]{
                                            new Item("Item 1", 35, 707),
                                            new Item("Item 2", 35, 707),
                                            new Item("Item 3", 35, 707),
                                            new Item("Item 4", 35, 707),
                                            new Item("Item 5", 35, 707),
                                            new Item("Item 6", 33, 167),
                                            new Item("Item 7", 35, 707),
                                            new Item("Item 8", 25, 125),
                                            new Item("Item 9", 50, 250),
                                            new Item("Item 10", 25, 375),
                                            new Item("Item 11", 58, 1155),
                                            new Item("Item 12", 71, 1414),
                                            new Item("Item 13", 50, 500),
                                            new Item("Item 14", 20, 200),
                                            new Item("Item 15", 33, 500),
                                            new Item("Item 16", 33, 1000),
                                            new Item("Item 17", 25, 125),
                                            new Item("Item 18", 33, 167),
                                            new Item("Item 19", 29, 577),
                                            new Item("Item 20", 29, 577),
                                            new Item("Item 21", 41, 1633),
                                            new Item("Item 22", 41, 1633),
                                            new Item("Item 23", 71, 2828),
                                    }
            };
            Data result = ks.Run();
            //Item[] myItems = new Item[]{
            //                            new Item("Item 1", 35, 707),
            //                            new Item("Item 2", 35, 707),
            //                            new Item("Item 3", 35, 707),
            //                            new Item("Item 4", 35, 707),
            //                            new Item("Item 5", 35, 707),
            //                            new Item("Item 6", 33, 167),
            //                            new Item("Item 7", 35, 707),
            //                            new Item("Item 8", 25, 125),
            //                            new Item("Item 9", 50, 250),
            //                            new Item("Item 10", 25, 375),
            //                            new Item("Item 11", 58, 1155),
            //                            new Item("Item 12", 71, 1414),
            //                            new Item("Item 13", 50, 500),
            //                            new Item("Item 14", 20, 200),
            //                            new Item("Item 15", 33, 500),
            //                            new Item("Item 16", 33, 1000),
            //                            new Item("Item 17", 25, 125),
            //                            new Item("Item 18", 33, 167),
            //                            new Item("Item 19", 29, 577),
            //                            new Item("Item 20", 29, 577),
            //                            new Item("Item 21", 41, 1633),
            //                            new Item("Item 22", 41, 1633),
            //                            new Item("Item 23", 71, 2828),
            //                            new Item("Item 24", 35, 707),
            //                            new Item("Item 25", 35, 707),
            //                            new Item("Item 26", 35, 707),
            //                            new Item("Item 27", 35, 707),
            //                            new Item("Item 28", 35, 707),
            //                            new Item("Item 29", 33, 167),
            //                            new Item("Item 30", 35, 707),
            //                            new Item("Item 31", 25, 125),
            //                            new Item("Item 32", 50, 250),
            //                            new Item("Item 33", 25, 375),
            //                            new Item("Item 34", 58, 1155),
            //                            new Item("Item 35", 71, 1414),
            //                            new Item("Item 36", 50, 500),
            //                            new Item("Item 37", 20, 200),
            //                            new Item("Item 38", 33, 500),
            //                            new Item("Item 39", 33, 1000),
            //                            new Item("Item 40", 25, 125),
            //                            new Item("Item 41", 33, 167),
            //                            new Item("Item 42", 29, 577),
            //                            new Item("Item 43", 29, 577),
            //                            new Item("Item 44", 41, 1633),
            //                            new Item("Item 45", 41, 1633),
            //                            new Item("Item 46", 71, 2828),
            //                            new Item("Item 47", 35, 707),
            //                            new Item("Item 48", 35, 707),
            //                            new Item("Item 49", 35, 707),
            //                            new Item("Item 50", 35, 707),
            //                            new Item("Item 51", 35, 707),
            //                            new Item("Item 52", 33, 167),
            //                            new Item("Item 53", 35, 707),
            //                            new Item("Item 54", 25, 125),
            //                            new Item("Item 55", 50, 250),
            //                            new Item("Item 56", 25, 375),
            //                            new Item("Item 57", 58, 1155),
            //                            new Item("Item 58", 71, 1414),
            //                            new Item("Item 59", 50, 500),
            //                            new Item("Item 60", 20, 200),
            //                            new Item("Item 61", 33, 500),
            //                            new Item("Item 62", 33, 1000),
            //                            new Item("Item 63", 25, 125),
            //                            new Item("Item 64", 33, 167),
            //                            new Item("Item 65", 29, 577),
            //                            new Item("Item 66", 29, 577),
            //                            new Item("Item 67", 41, 1633),
            //                            new Item("Item 68", 41, 1633),
            //                            new Item("Item 69", 71, 2828)
            //};
            //int myBagCapacity = 400;

            //Main
            //List<Item> result = FindOptimalSolution(myItems, myBagCapacity);
            //Console.WriteLine("Best choice: ");
            //Console.WriteLine(String.Join("\n", result));

            //BruteForce
            Console.WriteLine(string.Format("Items: {0}\n", ks.myItems.Length));
            Console.WriteLine(string.Format("Best value: {0}\n", result.BestValue));
            Console.WriteLine("Include:\n");
            result.Include.ForEach(i => Console.WriteLine(i + "\n"));

            sw.Stop();
            Console.WriteLine(string.Format("\nDuration: {0}\nPress a key to exit\n",
            sw.Elapsed.ToString()));
        }

        #region Main knapsack
        public static List<Item> FindOptimalSolution(Item[] items, int capacity)
        {

            int[,] valuesArray = new int[items.Length + 1, capacity + 1]; // * contains all items for rows and bag capacities for cols. Will keep the best values in each capacity of the bag.
            int[,] keepArray = new int[items.Length + 1, capacity + 1]; // * contains the same rows and cols like the valuesArray, but this keeps info if the current item is included in the best values for each bag capacity.

            for (int i = 1, itemsLen = items.Length + 1; i < itemsLen; i++) // * for each item
            {
                for (int k = 1; k < capacity + 1; k++) // * for each capacity of the bag (ex: if max capacity = 5 -> 1,2,3,4,5 / adds 1)
                {
                    if (items[i - 1].Weigth <= k) // * the weigth of the current item (items[i-1]) is le(less than or equal) to the current bag capacity
                    {
                        int remainingSpace = (k) - items[i - 1].Weigth; // * remaining space - the difference between the weigth of the currentItem and the current capacity of the bag.

                        if (remainingSpace > 0)
                        {
                            int valueAbove = valuesArray[i - 1, k]; // * row above, same coll
                            int sumValue = items[i - 1].Value + valuesArray[i - 1, remainingSpace - 1]; //* currentItem.Value + value from above row, remainingSpace col.

                            if (valueAbove > sumValue) // * gets the biggest value
                            {
                                valuesArray[i, k] = valueAbove;
                                keepArray[i, k] = 0;
                            }
                            else
                            {
                                valuesArray[i, k] = sumValue;
                                keepArray[i, k] = 1;
                            }
                        }
                        else // * remaining space == 0
                        {
                            valuesArray[i, k] = items[i - 1].Value;
                            keepArray[i, k] = 1;
                        }
                    }
                }
            }

            List<Item> bestChoice = new List<Item>();

            int remainSpace = capacity;
            int item = items.Length;

            while (item >= 0)
            {
                int toBeAdded = keepArray[item, remainSpace - 1];

                if (toBeAdded == 1)
                {
                    bestChoice.Add(items[item - 1]);
                    remainSpace -= items[item - 1].Weigth;
                }
                item--;
            }
            return bestChoice;
        }
        #endregion Main knapsack

        #region Brute Force Knapsack
        // O(2^n * n)
        class KnapsackBruteForce
        {
            public double myBagCapacity { get; set; }
            public Item[] myItems { get; set; }

            public Data Run()
            {
                var bestValue = 0d;
                var bestPosition = 0;
                var size = myItems.Length;

                var permutations = (long)Math.Pow(2, size);
                for (var i = 0; i < permutations; i++)
                {
                    var total = 0d;
                    var weight = 0d;
                    for (var j = 0; j < size; j++)
                    {
                        // if bit not included then skip
                        if (((i >> j) & 1) != 1) continue;

                        total += myItems[j].Value;
                        weight += myItems[j].Weigth;
                    }

                    if (weight <= myBagCapacity && total > bestValue)
                    {
                        bestPosition = i;
                        bestValue = total;
                    }
                }

                var include = new List<Item>();
                for (var j = 0; j < size; j++)
                {
                    // if bit match then add
                    if (((bestPosition >> j) & 1) == 1)
                    {
                        include.Add(myItems[j]);
                    }
                }
                return new Data { BestValue = bestValue, Include = include };
            }
        }
            class Data
        {
            public List<Item> Include { get; set; }
            public double BestValue { get; set; }
        }
        #endregion Brute Force Knapsack
    }
}
