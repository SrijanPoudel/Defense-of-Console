//Written by Shrijan Paudel
//DAte:1/27


//Defense  of Consolas Program 

using System;
using The_Defense_of_Consolas;

namespace DefenseOfConsolas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Asking for the target row and column
            Console.Write("Target Row? ");
            int targetRow = Convert.ToInt32(Console.ReadLine());

            Console.Write("Target Column? ");
            int targetColumn = Convert.ToInt32(Console.ReadLine());

            Console.Title = "DefenseOfConsolas"; // title of the console


            DefenseDeployment deployment = new DefenseDeployment();

            deployment.DeployDefense(targetRow, targetColumn); // calling method with parameters


        }
    }
}