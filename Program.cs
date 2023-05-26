using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    // Define a TeamMember class to represent a team member
    public class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store the team members
            List<TeamMember> teamMembers = new List<TeamMember>();
            string memberName = "";

            // Prompt the user to enter a team member's name
            Console.Write("Enter team member's name (leave blank to stop): ");
            memberName = Console.ReadLine();

            // Keep prompting the user to enter team members until they enter a blank name
            while (memberName != "")
            {
                // Create a new TeamMember object and set its properties
                TeamMember member = new TeamMember();
                member.Name = memberName;

                Console.Write("Enter team member's skill level: ");
                member.SkillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter team member's courage factor: ");
                member.CourageFactor = double.Parse(Console.ReadLine());

                // Add the new TeamMember object to the teamMembers list
                teamMembers.Add(member);

                // Prompt the user to enter another team member's name
                Console.Write("Enter team member's name (leave blank to stop): ");
                memberName = Console.ReadLine();
            }

            // Prompt the user to enter the number of trial runs
            Console.Write("Enter the number of trial runs: ");
            int trialRuns = int.Parse(Console.ReadLine());

            // Set the bank's base difficulty level to 100
            int bankBaseDifficultyLevel = 100;

            // Create a Random object to generate random luck values
            Random random = new Random();

            // Calculate the sum of the team members' skill levels
            int teamSkillLevelSum = 0;
            foreach (TeamMember member in teamMembers)
            {
                teamSkillLevelSum += member.SkillLevel;
            }

            // Run the scenario multiple times based on the user-entered number of trial runs
            for (int i = 0; i < trialRuns; i++)
            {
                // Choose a new luck value for this trial run and add it to the bank's difficulty level
                int luckValue = random.Next(-10, 11);
                int bankDifficultyLevel = bankBaseDifficultyLevel + luckValue;

                // Print out a report showing the team's combined skill level and the bank's difficulty level for this trial run
                Console.WriteLine($"Trial Run {i + 1}:");
                Console.WriteLine($"Team Skill Level: {teamSkillLevelSum}");
                Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");

                // Compare the team's skill level sum with the bank's difficulty level and print out a success or failure message for this trial run
                if (teamSkillLevelSum >= bankDifficultyLevel)
                {
                    Console.WriteLine("Success! The team has enough skill to rob the bank.");
                }
                else
                {
                    Console.WriteLine("Failure! The team doesn't have enough skill to rob the bank.");
                }

                Console.WriteLine();
            }
        }
    }
}
