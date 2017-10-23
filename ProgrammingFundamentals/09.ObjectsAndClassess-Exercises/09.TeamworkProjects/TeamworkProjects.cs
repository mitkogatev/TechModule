using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main(string[] args)
        {
            int numOfTeams = int.Parse(Console.ReadLine());
            for (int i = 0; i < numOfTeams; i++)
            {
                CreateTeam(Console.ReadLine().Split('-'));
            }
            string line = Console.ReadLine();
            while (line !="end of assignment")
            {
                AssignMembers(line);

                line = Console.ReadLine();

            }
            //Console.WriteLine();
            PrintResults();
        }

        private static void PrintResults()
        {
            List<string> teamsToDisband = new List<string>();
            foreach (var team in Teams.teams.OrderBy(t=>t.Value.Name).OrderByDescending(t=>t.Value.Members.Count))
            {
                if (team.Value.Members.Count != 0)
                {
                    Console.WriteLine($"{team.Value.Name}");
                    Console.WriteLine($"- {team.Key}");
                    foreach (var member in team.Value.Members.OrderBy(m => m))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
                else
                    teamsToDisband.Add(team.Value.Name);
            }
            Console.WriteLine("Teams to disband:");
            Console.WriteLine(String.Join(Environment.NewLine,teamsToDisband));
        }

        private static void AssignMembers(string line)
        {
            string[] memArgs = Regex.Split(line, @"->");
            string member = memArgs[0];
            string team = memArgs[1];
            if (!Teams.teams.Any(t => t.Value.Name == team))
                Console.WriteLine($"Team {team} does not exist!");
            else
            {
                if (Teams.teams.Any(t => t.Value.Members.Contains(member)) || Teams.teams.ContainsKey(member))
                {
                    Console.WriteLine($"Member {member} cannot join team {team}!");
                }
                else
                {
                    Teams.teams.Where(t=>t.Value.Name==team).Select(t => t.Value).First().AddMember(member);//WOW!!!
                }
            }
            
        }

        private static void CreateTeam(string[] input)
        {
            string user = input[0];
            string team = input[1];
            if (!Teams.teams.Any(t => t.Value.Name == team))//if !exists
            {
                if (!Teams.teams.Keys.Contains(user))//if !user is creator
                {
                    Teams.teams.Add(user,new Team(team));
                    Console.WriteLine($"Team {team} has been created by {user}!");
                }
                else
                {
                    Console.WriteLine($"{user} cannot create another team!");
                }
            }
            else
            {
                Console.WriteLine($"Team {team} was already created!");
            }

        }
    }
    class Team
    {
        public string Name { get; set; }
        //public string Creator { get; set; }
        public List<string> Members { get; set; }
        public Team(string inp)
        {
            this.Name = inp;
            this.Members = new List<string>();
        }
        public void AddMember(string member)
        {
            this.Members.Add(member);
        }
    }
    class Teams
    {
        public static Dictionary<string, Team> teams = new Dictionary<string,Team>();
    }
}
