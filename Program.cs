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

            // Set the bank's difficulty level to 100
            int bankDifficultyLevel = 100;

            // Create a random number between -10 and 10 for the heist's luck value and add it to the bank's difficulty level
            Random random = new Random();
            int luckValue = random.Next(-10, 11);
            bankDifficultyLevel += luckValue;

            // Calculate the sum of the team members' skill levels
            int teamSkillLevelSum = 0;
            foreach (TeamMember member in teamMembers)
            {
                teamSkillLevelSum += member.SkillLevel;
            }

            // Print out a report showing the team's combined skill level and the bank's difficulty level
            Console.WriteLine($"Team Skill Level: {teamSkillLevelSum}");
            Console.WriteLine($"Bank Difficulty Level: {bankDifficultyLevel}");

            // Compare the team's skill level sum with the bank's difficulty level and print out a success or failure message
            if (teamSkillLevelSum >= bankDifficultyLevel)
            {
                Console.WriteLine("Success! The team has enough skill to rob the bank.");
            }
            else
            {
                Console.WriteLine("Failure! The team doesn't have enough skill to rob the bank.");
            }
        }
    }
}
