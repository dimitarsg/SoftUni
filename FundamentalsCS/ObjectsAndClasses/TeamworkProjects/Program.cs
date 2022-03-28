using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamworkProjects
{
    public class Team
    {
        public Team(string teamName, string teamCreator)
        {
            this.TeamName = teamName;
            this.TeamCreator = teamCreator;

            this.TeamMember = new List<string>();
        }

        public string TeamName { get; set; }
        public string TeamCreator { get; set; }
        public List<string> TeamMember { get; set; }

        public void AddMemeber(string teamMember)
        {
            this.TeamMember.Add(teamMember);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();

            for (int i = 1; i <= teamsCount; i++)
            {
                List<string> teamInput = Console.ReadLine()
                .Split('-', (char)StringSplitOptions.RemoveEmptyEntries)
                .Select(e => e.Trim())
                .ToList()
                .Where(e => !string.IsNullOrWhiteSpace(e))
                .ToList();

                string teamName = teamInput[1];
                string creatorName = teamInput[0];

                if (teams.Any(item => item.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                    continue;
                }

                if (teams.Any(item => item.TeamCreator == creatorName))
                {
                    Console.WriteLine($"{creatorName} cannot create another team!");
                    continue;
                }

                Team newTeam = new Team(teamName, creatorName);
                teams.Add(newTeam);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");

            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end of assignment")
                {
                    break;
                }

                string[] commandInput = command
                    .Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string teamName = commandInput[1];
                string teamMember = commandInput[0];
                Team teamToCheck = teams.FirstOrDefault(t => t.TeamName == teamName);

                if (teamToCheck == null)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (teams.Any(m => m.TeamMember.Contains(teamMember)) || teams.Any(c => c.TeamCreator == teamMember))
                {
                    Console.WriteLine($"Member {teamMember} cannot join team {teamName}!");
                    continue;
                }

                Team team = teams.FirstOrDefault(item => item.TeamName == teamName);
                team.AddMemeber(teamMember);
            }

            List<Team> teamsWithMembers = teams
                .Where(item => item.TeamMember.Count > 0)
                .OrderByDescending(t => t.TeamMember.Count)
                .ThenBy(t => t.TeamName)
                .ToList();
            List<Team> teamsWithNoMembers = teams
                .Where(item => item.TeamMember.Count == 0)
                .OrderBy(t => t.TeamName)
                .ToList();

            foreach (var item in teamsWithMembers)
            {
                Console.WriteLine($"{item.TeamName}");
                Console.WriteLine($"- {item.TeamCreator}");

                foreach (var member in item.TeamMember.OrderBy(m => m))
                {
                    Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine("Teams to disband:");

            foreach (var team in teamsWithNoMembers)
            {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}

