// See https://aka.ms/new-console-template for more information
string architectName = Console.ReadLine()!;
int projectsCount = int.Parse(Console.ReadLine()!);

int hoursPerProject = 3;
int totalHours = projectsCount * hoursPerProject;

Console.WriteLine($"The architect {architectName} will need {totalHours} hours to complete {projectsCount} project/s.");