using System;
using System.Collections.Generic;

namespace plan_your_heist
{
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
            List<TeamMember> teamMembers = new List<TeamMember>();
            string memberName = "";

            Console.Write("Enter team member's name (leave blank to stop): ");
            memberName = Console.ReadLine();

            while (memberName != "")
            {
                TeamMember member = new TeamMember();
                member.Name = memberName;

                Console.Write("Enter team member's skill level: ");
                member.SkillLevel = int.Parse(Console.ReadLine());

                Console.Write("Enter team member's courage factor: ");
                member.CourageFactor = double.Parse(Console.ReadLine());

                teamMembers.Add(member);

                Console.Write("Enter team member's name (leave blank to stop): ");
                memberName = Console.ReadLine();
            }

            Console.WriteLine($"Number of team members: {teamMembers.Count}");

            foreach (TeamMember member in teamMembers)
            {
                Console.WriteLine($"Name: {member.Name}");
                Console.WriteLine($"Skill Level: {member.SkillLevel}");
                Console.WriteLine($"Courage Factor: {member.CourageFactor}");
            }
        }
    }
}
