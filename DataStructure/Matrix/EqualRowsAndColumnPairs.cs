using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Matrix
{ 
    public class EqualRowsAndColumnPairs
    {
        public int EqualPairs(int[][] matrix)
        {
            int n = matrix.Length;
            Dictionary<string, int> rowMap = new Dictionary<string, int>();
            Dictionary<string, int> colMap = new Dictionary<string, int>();

            // Process rows
            for (int i = 0; i < n; i++)
            {
                string rowString = string.Join(",", matrix[i]);
                if (rowMap.ContainsKey(rowString))
                {
                    rowMap[rowString]++;
                }
                else
                {
                    rowMap[rowString] = 1;
                }
            }

            // Process columns
            for (int j = 0; j < n; j++)
            {
                string[] colArray = new string[n];
                for (int i = 0; i < n; i++)
                {
                    colArray[i] = matrix[i][j].ToString();
                }
                string colString = string.Join(",", colArray);
                if (colMap.ContainsKey(colString))
                {
                    colMap[colString]++;
                }
                else
                {
                    colMap[colString] = 1;
                }
            }

            // Count equal row-column pairs
            int equalPairsCount = 0;
            foreach (var row in rowMap)
            {
                if (colMap.ContainsKey(row.Key))
                {
                    equalPairsCount += row.Value * colMap[row.Key];
                }
            }

            return equalPairsCount;
            
        }
    }
}
//This is sp uniffecient , we have to use hash maps.
/*int size = matrix.Length;
            int equalPairsCount = 0;

            // Loop over each row
            for (int i = 0; i < size; i++)
            {
                // For each row, loop over each column
                for (int j = 0; j < size; j++)
                {
                    bool isEqual = true;
                    // Compare the i-th row with the j-th column
                    for (int k = 0; k < size; k++)
                    {
                        if (matrix[i][k] != matrix[k][j])
                        {
                            isEqual = false;
                            break;
                        }
                    }
                    if (isEqual)
                    {
                        equalPairsCount++;
                    }
                }
            }

            return equalPairsCount;*/