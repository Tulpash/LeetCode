string? solutionDir = Directory.GetParent(Directory.GetCurrentDirectory())?.Parent?.Parent?.Parent?.FullName;
if (string.IsNullOrEmpty(solutionDir))
    throw new Exception("Неудалось полусить папку решения");

string tasksDir = Path.Combine(solutionDir, "LeetCode.Tasks");
if (!Directory.Exists(tasksDir))
    throw new Exception("Неудалось получить папку проекта с задачами");

List<Line> easy = GetLinesFromDirectory(Path.Combine(tasksDir, "Easy"));
List<Line> medium = GetLinesFromDirectory(Path.Combine(tasksDir, "Medium"));
List<Line> hard = GetLinesFromDirectory(Path.Combine(tasksDir, "Hard"));

string readMeFile = Path.Combine(solutionDir, "README.md");
if (File.Exists(readMeFile))
    File.Delete(readMeFile);

using (StreamWriter writer = new(readMeFile))
{
    WriteLines(writer, easy, "Easy");
    WriteLines(writer, medium, "Medium");
    WriteLines(writer, hard, "Hard");
}
   
void WriteLines(StreamWriter writer, List<Line> lines, string tableName)
{
    writer.WriteLine($"### {tableName}");
    if (lines.Any())
    {
        writer.WriteLine("|Id|Name|Link|");
        writer.WriteLine("|:-|:-|:-|");
        foreach (Line line in lines)
            writer.WriteLine($"|{line.Number}|{line.Name}|{line.Link}|");
    }
    writer.WriteLine();
}
List<Line> GetLinesFromDirectory(string directory)
{
    if (!Directory.Exists(directory))
        return new();

    string[] files = Directory.GetDirectories(directory).Select(dir => Path.Combine(dir, "Solution.CS")).ToArray();
    List<Line> lines = new();
    foreach (string file in files)
    {
        if (!File.Exists(file))
            continue;

        using (StreamReader reader = new(file))
        {
            string first = reader.ReadLine() ?? string.Empty;
            string second = reader.ReadLine() ?? string.Empty;

            lines.Add(new()
            {
                Number = int.TryParse(first.AsSpan(3, first.IndexOf('.') - 3), out int num) ? num : -1, 
                Name = first.AsMemory(first.IndexOf('.') + 1),
                Link = second.AsMemory(2)
            });
        }
    }

    return lines.OrderBy(l => l.Number).ToList();
}

struct Line
{
    public int Number {  get; set; }
    public ReadOnlyMemory<char>? Name { get; set; }
    public ReadOnlyMemory<char>? Link { get; set; }
}