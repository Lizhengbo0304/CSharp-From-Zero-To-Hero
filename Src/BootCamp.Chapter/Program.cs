using System;

namespace BootCamp.Chapter
{
    internal class Program
    {
        #region Private Methods

        private static double GetBMI(float weight, float height)
        {
            return weight / Math.Pow(height / 100, 2);
        }

        private static void Main(string[] args)
        {
            Console.Write("Name:");
            string FirstPersonName = Console.ReadLine();
            Console.Write("Age:");
            int FirstPersonAge = int.Parse(Console.ReadLine());
            Console.Write("Weight(KG):");
            float FirstPersonWeight = float.Parse(Console.ReadLine());
            Console.Write("Height(CM):");
            float FirstPersonHeight = float.Parse(Console.ReadLine());

            Console.WriteLine($@"{FirstPersonName} is {FirstPersonAge} years old, his weight is {FirstPersonWeight} kg and his height is {FirstPersonHeight} cm.");
            Console.WriteLine($@"{FirstPersonName}'s BMI = {GetBMI(FirstPersonWeight, FirstPersonHeight).ToString("0.00")}");

            Console.Write("Name:");
            string SndPersonName = Console.ReadLine();
            Console.Write("Age:");
            int SndPersonAge = int.Parse(Console.ReadLine());
            Console.Write("Weight(KG):");
            float SndPersonWeight = float.Parse(Console.ReadLine());
            Console.Write("Height(CM):");
            float SndPersonHeight = float.Parse(Console.ReadLine());

            Console.WriteLine($@"{SndPersonName} is {SndPersonAge} years old, his weight is {SndPersonWeight} kg and his height is {SndPersonHeight} cm.");
            Console.WriteLine($@"{SndPersonName}'s BMI = {GetBMI(SndPersonWeight, SndPersonHeight).ToString("0.00")}");
        }

        #endregion Private Methods
    }
}