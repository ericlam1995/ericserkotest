using System;
using System.Collections.Generic;
using System.Linq;

namespace Checkout
{
    public class Till
    {

        private Dictionary<char, int> _items = new Dictionary<char, int>{
            {'A', 0},
            {'B', 0},
            {'C', 0},
            {'D', 0}
        };

        public double Total()
        {
            double total = 0;
            foreach (var item in _items)
            {
                if (item.Key.Equals('A'))
                {
                    double totalAitem = 0;
                    if(item.Value == 3)
                    {
                        totalAitem = (item.Value * 50) - 20;
                    }
                    else
                    {
                        totalAitem = (item.Value * 50);
                    }
                    total += totalAitem;
                }
                else if (item.Key.Equals('B'))
                {
                    total += AddB(item.Value);
                }
                else if (item.Key.Equals('C'))
                {
                    total += AddItemC(item);
                }
                else if(item.Key.Equals('D'))
                {
                    total += AddItemD(item);
                }
            }
            return total;
        }

        //updated AddItemD method
        private static double AddItemD(KeyValuePair<char, int> item) //Don't use unnecessary code as it cause mistakes
        {                                                            //I modified the code to make it clear
            //if (item.Key.Equals('D'))
            //{
            //    total += 15 * item.Value;
            //}

            //return total;
            int numofDitem = item.Value;
            return numofDitem * 15;
        }

        //Updated AddItemC method
        private static double AddItemC(KeyValuePair<char, int> item)
        {
            int numofCitem = item.Value;
            if(numofCitem <= 6)
            {
                return numofCitem * 20;
            }
            else
            {
                return 0;
            }
            //if (item.Key.Equals('C'))
            //{
            //    total += 15 * item.Value;
            //}

            //return total;
        }
        //Updated AddB method
        private double AddB(int numberItems)
        {
            //double items = Double.Parse(numberItems);

            //if (items == 0) return 0;

            //var cost = items * 30;
            //var numberOfPairs = items / 2;

            //// discount is 15 on each pair
            //var discount = numberOfPairs * 15;
            //return cost - discount;
            if(numberItems == 2)
            {
                return ((30 * numberItems) / 2) + 15;
            }
            else
            {
                return 30 * numberItems;
            }
        }


        public void Scan(string items)
        {
            foreach (var item in items)
            {
                _items[item]++;
            }
        }
    }
}