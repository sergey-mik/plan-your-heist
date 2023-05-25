using System;

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
            TeamMember member = new TeamMember();

            Console.Write("Enter team member's name: ");
            member.Name = Console.ReadLine();

            Console.Write("Enter team member's skill level: ");
            member.SkillLevel = int.Parse(Console.ReadLine());

            Console.Write("Enter team member's courage factor: ");
            member.CourageFactor = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {member.Name}");
            Console.WriteLine($"Skill Level: {member.SkillLevel}");
            Console.WriteLine($"Courage Factor: {member.CourageFactor}");
        }
    }
}
