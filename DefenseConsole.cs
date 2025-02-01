//Written by Shrijan Paudel
//01/27/2025

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Defense_of_Consolas
{
        public class DefenseDeployment
        {
            // Method to deploy defense based on target row and column
            public void DeployDefense(int targetRow, int targetColumn)
            {
                Console.ForegroundColor = ConsoleColor.Green; // Change console color to Green

                Console.WriteLine("Deploying Defense..");
                Console.WriteLine($"({targetRow},{targetColumn - 1})"); // Left row
                Console.WriteLine($"({targetRow - 1},{targetColumn})"); // Above target
                Console.WriteLine($"({targetRow},{targetColumn + 1})"); // Right rpw
                Console.WriteLine($"({targetRow + 1},{targetColumn})"); // Below target

                Console.Beep(); // Beep sound for deployment notification
            }
        }
    }

