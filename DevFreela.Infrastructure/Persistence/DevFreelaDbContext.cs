using DevFreela.Core.Entities;

namespace DevFreela.Infrastructure.Persistence
{
    public class DevFreelaDbContext
    {
        public DevFreelaDbContext()
        {
            Projects = new List<Project>
            {
                new Project("Projeto ASP NET Core 1", "Minha descrição de projeto 1", 1, 1, 10000),
                new Project("Projeto ASP NET Core 2", "Minha descrição de projeto 2", 1, 1, 20000),
                new Project("Projeto ASP NET Core 1", "Minha descrição de projeto 3", 1, 1, 30000)
            };
            Users = new List<User>
            {
                new User("Victor de Oliveira", "vittoliveiraa@live.com", new DateTime(1992, 11, 14)),
                new User("Adriano Moreira", "adriano@live.com", new DateTime(1980, 05, 12)),
                new User("Romero Brito", "romero@live.com", new DateTime(1960, 03, 10))
            };
            Skills = new List<Skill>
            {
                new Skill("C#"),
                new Skill(".NET"),
                new Skill("SQL")
            };
        }
        public List<Project> Projects { get; set; }
        public List<User> Users { get; set; }
        public List<Skill> Skills { get; set; }
    }
}
