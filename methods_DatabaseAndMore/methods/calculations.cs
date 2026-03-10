using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nigganigga
{
    internal class calculations
    {
        private int[] array_1d = { 3, 3, 3 };

        private int[,] array_2d = {
            {2, 1, 1, 1 },
            {1, 3, 1, 1}
                          };

        private int n1 = 0;

        public string D2()
        {
            string display = "";
            for (int c = 0; c < array_2d.GetLength(0); c++)
            {
                display += $"Player {c + 1}: ";
                for (int r = 0; r < array_2d.GetLength(1); r++)
                {
                    display += array_2d[c, r] + " ";
                }
                display += "\n";
            }
            return display;
        }

        public string Display_score()
        {
            string score = "Player 1:";
            foreach (int black in array_1d)
            {
                score += black + " ".ToString();
            }
            return score;
        }

        public int Total_score()
        {
            /*for (int i = 0; i<array_1d.Length ; i++)
            {
                n1 += array_1d[i];
            }
            */
            foreach (int score in array_1d)
            {
                n1 += array_1d[score - 1];
            }
            return n1;
        }

        public int Average()
        {
            int n2 = 0;
            n2 += n1 / array_1d.Length;
            return n2;
        }
    }
}